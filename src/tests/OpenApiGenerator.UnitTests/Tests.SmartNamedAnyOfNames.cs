﻿using OpenApiGenerator.Core.Helpers;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public partial class Tests
{
    [TestMethod]
    public void SmartNamedAnyOfNames_Valid()
    {
        SmartNamedAnyOfNames.ComputeSmartName(
            typeName: "ChatCompletionRequestMessageContentPartText",
            className: "ChatCompletionRequestMessageContentPart").Should().Be("Text");
    }
    
    [TestMethod]
    public void DateTimeParameterSerialization_Valid()
    {
        $"{new DateTime(year: 2022, 1, 1):yyyy-MM-dd}".Should().Be("2022-01-01");
        $"{new DateTime(year: 2022, 1, 1):yyyy-MM-ddTHH:mm:ssZ}".Should().Be("2022-01-01T00:00:00Z");
    }
    
    [TestMethod]
    public void Url_Concat()
    {
        var baseUri = new Uri("https://localhost:7293");
        
        new Uri(baseUri.GetLeftPart(UriPartial.Authority) + "/api/Stats", UriKind.RelativeOrAbsolute)
            .Should().Be(new Uri("https://localhost:7293/api/Stats"));
    }
}