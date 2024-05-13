using System.CommandLine;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Generators;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Cli.Commands;

public class GenerateCommand : Command
{
    public GenerateCommand() : base(name: "generate", description: "Generates client sdk using a OpenAPI spec.")
    {
        var inputOption = new Argument<string>(
            name: "input",
            getDefaultValue: () => string.Empty,
            description: "Input file path");
        var outputOption = new Option<string>(
            aliases: ["--output", "-o"],
            getDefaultValue: () => string.Empty,
            description: "Output file path");
        var namespaceOption = new Option<string>(
            aliases: ["--namespace", "-n"],
            getDefaultValue: () => string.Empty,
            description: "Namespace for the generated code");
        var clientClassNameOption = new Option<string>(
            aliases: ["--clientClassName", "-c"],
            getDefaultValue: () => string.Empty,
            description: "Client class name");
        var singleFileOption = new Option<bool>(
            aliases: ["--single-file", "-s"],
            getDefaultValue: () => false,
            description: "Generate all models in a single file");
        AddArgument(inputOption);
        AddOption(outputOption);
        AddOption(namespaceOption);
        AddOption(clientClassNameOption);
        AddOption(singleFileOption);

        this.SetHandler(
            HandleAsync,
            inputOption,
            outputOption,
            namespaceOption,
            clientClassNameOption,
            singleFileOption);
    }

    private static async Task HandleAsync(
        string inputPath,
        string outputPath,
        string @namespace,
        string clientClassName,
        bool generateAsSingleFile)
    {
        var yaml = await File.ReadAllTextAsync(inputPath).ConfigureAwait(false);
        
        var name = Path.GetFileNameWithoutExtension(inputPath);
        
        if (string.IsNullOrWhiteSpace(@namespace))
        {
            @namespace = name.ToPropertyName();
        }
        if (string.IsNullOrWhiteSpace(clientClassName))
        {
            clientClassName = $"{name.ToPropertyName()}Api";
        }
        
        var settings = new Settings(
            TargetFramework: "netstandard2.0",
            Namespace: @namespace,
            ClassName: clientClassName,
            GenerateConstructors: false,
            GenerateMethods: false,
            NamingConvention: default,
            JsonSerializerType: default,
            UseRequiredKeyword: default,
            IncludeOperationIds: [],
            GenerateModels: true,
            ModelStyle: default,
            IncludeModels: []
        );

        var models = ModelGeneratorMethods.PrepareData((yaml, settings));
        var files = models
            .Select(x => ModelGeneratorMethods.GetSourceCode(x))
            .ToArray();
        
        if (generateAsSingleFile)
        {
            var text = string.Join(Environment.NewLine, files.Select(x => x.Text));
            await File.WriteAllTextAsync(Path.Combine(outputPath, $"{name}.cs"), text).ConfigureAwait(false);
            return;
        }
        
        if (string.IsNullOrWhiteSpace(outputPath))
        {
            outputPath = name;
            Directory.CreateDirectory(outputPath);
        }
        
        foreach (var file in files)
        {
            await File.WriteAllTextAsync(Path.Combine(outputPath, file.Name), file.Text).ConfigureAwait(false);
        }
    }
}