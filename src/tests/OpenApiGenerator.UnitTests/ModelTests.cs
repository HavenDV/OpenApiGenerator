﻿using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using OpenApiGenerator.Core.Generators;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public class ModelTests :
    VerifyBase
{
    private Settings DefaultSettings => new(
        TargetFramework: "netstandard2.0",
        Namespace: "G",
        ClassName: "Api",
        NamingConvention: default,
        IncludeOperationIds: [],
        GenerateModels: true,
        ModelStyle: default,
        IncludeModels: []
    );

    private Task VerifyAsync(
        ImmutableArray<ModelData> models,
        [CallerMemberName] string? callerName = null)
    {
        return Verify(models
                    .Select(x => x with { Parents = [] })
                    .ToArray())
                .UseDirectory($"Snapshots/{callerName}")
                .UseFileName("_")
                //.AutoVerify()
            ;
    }

    [TestMethod]
    public Task OpenAi()
    {
        var yaml = H.Resources.openai_yaml.AsString();
        var settings = DefaultSettings with
        {
            //IncludeModels = ["CreateCompletionResponse"],
        };

        var models = ModelGeneratorMethods.PrepareData((yaml, settings));

        return VerifyAsync(models);
    }

    [TestMethod]
    public Task Ollama()
    {
        var yaml = H.Resources.ollamacurated_yaml.AsString();
        var settings = DefaultSettings;

        var models = ModelGeneratorMethods.PrepareData((yaml, settings));

        return VerifyAsync(models);
    }
}