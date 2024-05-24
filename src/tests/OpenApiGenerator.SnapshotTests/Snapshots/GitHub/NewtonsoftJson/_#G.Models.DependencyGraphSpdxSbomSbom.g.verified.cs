﻿//HintName: G.Models.DependencyGraphSpdxSbomSbom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbom
    {
        /// <summary>
        /// The SPDX identifier for the SPDX document.
        /// <br/>Example: SPDXRef-DOCUMENT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("SPDXID", Required = global::Newtonsoft.Json.Required.Always)]
        public string SPDXID { get; set; } = default!;

        /// <summary>
        /// The version of the SPDX specification that this document conforms to.
        /// <br/>Example: SPDX-2.3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spdxVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string SpdxVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creationInfo", Required = global::Newtonsoft.Json.Required.Always)]
        public DependencyGraphSpdxSbomSbomCreationInfo CreationInfo { get; set; } = default!;

        /// <summary>
        /// The name of the SPDX document.
        /// <br/>Example: github/github
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The license under which the SPDX document is licensed.
        /// <br/>Example: CC0-1.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataLicense", Required = global::Newtonsoft.Json.Required.Always)]
        public string DataLicense { get; set; } = default!;

        /// <summary>
        /// The name of the repository that the SPDX document describes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentDescribes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DocumentDescribes { get; set; } = default!;

        /// <summary>
        /// The namespace for the SPDX document.
        /// <br/>Example: https://github.com/example/dependency_graph/sbom-123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documentNamespace", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentNamespace { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("packages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<DependencyGraphSpdxSbomSbomPackages> Packages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}