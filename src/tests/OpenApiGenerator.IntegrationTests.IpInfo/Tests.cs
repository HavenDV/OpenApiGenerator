﻿using System.Text.Json;

namespace OpenApiGenerator.IntegrationTests;

[TestClass]
public class NSwagGeneratorTests
{
    [TestMethod]
    public void Models()
    {
        var json = JsonSerializer.Serialize(new Error
        {
            Error1 = new()
            {
                Title = "title",
                Message = "message",
            }
        }, SourceGenerationContext.Default.Error);
        
        var error = JsonSerializer.Deserialize(json, SourceGenerationContext.Default.Error);
        error.Should().NotBeNull();
        error!.Error1.Should().BeEquivalentTo(new ErrorError
        {
            Title = "title",
            Message = "message",
        });
    }
}