﻿using Microsoft.CodeAnalysis;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using OpenApiGenerator.Generators;

namespace OpenApiGenerator.SnapshotTests;

public partial class Tests
{
    private static OpenApiDocument PetStore { get; } = new OpenApiDocument
    {
        Info = new OpenApiInfo
        {
            Version = "1.0.0",
            Title = "Swagger Petstore (Simple)",
        },
        Servers = new List<OpenApiServer>
        {
            new() { Url = "http://petstore.swagger.io/api" },
        },
        Paths = new OpenApiPaths
        {
            ["/pets"] = new()
            {
                Operations = new Dictionary<OperationType, OpenApiOperation>
                {
                    [OperationType.Get] = new()
                    {
                        Description = "Returns all pets from the system that the user has access to",
                        Responses = new OpenApiResponses
                        {
                            ["200"] = new()
                            {
                                Description = "OK",
                            },
                        },
                    },
                },
            },
        },
    };
    
    [TestMethod]
    public Task Empty()
    {
        return CheckSourceAsync<ModelGenerator>([]);
    }
    
    [TestMethod]
    public Task Ollama()
    {
        return CheckSourceAsync<ModelGenerator>([
            new CustomAdditionalText(
                path: H.Resources.ollamacurated_yaml.FileName,
                text: H.Resources.ollamacurated_yaml.AsString())
        ], new Dictionary<string, string>
        {
            //["build_property.OpenApiGenerator_IncludeOperationIds"] = "ListModels",
            //["build_property.OpenApiGenerator_IncludeModels"] = "CreateModerationResponse;Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
        }); //, additionalGenerators: [new ClientGenerator()]
    }
    
    [TestMethod]
    public Task OpenAi()
    {
        return CheckSourceAsync<ModelGenerator>([
            new CustomAdditionalText(
                path: H.Resources.openai_yaml.FileName,
                text: H.Resources.openai_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.OpenApiGenerator_IncludeOperationIds"] = "ListModels",
            ["build_property.OpenApiGenerator_IncludeModels"] = "CreateModerationResponse;Error;ErrorResponse;ListModelsResponse;Model;DeleteModelResponse;CreateCompletionRequest",
        }, additionalGenerators: [new ClientGenerator()]);
    }
    
    [TestMethod]
    public Task OpenAi_CreateCompletionResponse()
    {
        return CheckSourceAsync<ModelGenerator>([
            new CustomAdditionalText(
                path: H.Resources.openai_yaml.FileName,
                text: H.Resources.openai_yaml.AsString())
        ], new Dictionary<string, string>
        {
            ["build_property.OpenApiGenerator_IncludeModels"] = "CreateCompletionResponse",
        });
    }
    
    [TestMethod]
    public Task YamlWithLocalFile()
    {
        return CheckSourceAsync<ModelGenerator>([
            new CustomAdditionalText(
                path: "openapi.yaml",
                text: H.Resources.ipinfo_yaml.AsString()),
        ]);
    }

    [TestMethod]
    public Task OpenApi3_0_Yaml()
    {
        var yaml = PetStore.Serialize(OpenApiSpecVersion.OpenApi3_0, OpenApiFormat.Yaml);
        
        return CheckSourceAsync<ModelGenerator>([
            new CustomAdditionalText("openapi.yaml", yaml),
        ]);
    }

    [TestMethod]
    public Task YamlWithUrl()
    {
        return CheckSourceAsync<ModelGenerator>([
            new CustomAdditionalText("https://dedoose-rest-api.onrender.com/swagger/v1/swagger.json", string.Empty),
        ]);
    }
}