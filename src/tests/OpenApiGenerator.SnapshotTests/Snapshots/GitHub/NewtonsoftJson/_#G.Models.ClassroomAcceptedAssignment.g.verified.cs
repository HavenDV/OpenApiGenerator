﻿//HintName: G.Models.ClassroomAcceptedAssignment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub Classroom accepted assignment
    /// </summary>
    public sealed partial class ClassroomAcceptedAssignment
    {
        /// <summary>
        /// Unique identifier of the repository.<br/>
        /// Example: 42
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Whether an accepted assignment has been submitted.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submitted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Submitted { get; set; } = default!;

        /// <summary>
        /// Whether a submission passed.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passing", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Passing { get; set; } = default!;

        /// <summary>
        /// Count of student commits.<br/>
        /// Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int CommitCount { get; set; } = default!;

        /// <summary>
        /// Most recent grade.<br/>
        /// Example: 10/10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grade", Required = global::Newtonsoft.Json.Required.Always)]
        public string Grade { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("students", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimpleClassroomUser> Students { get; set; } = default!;

        /// <summary>
        /// A GitHub repository view for Classroom
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroomRepository Repository { get; set; } = default!;

        /// <summary>
        /// A GitHub Classroom assignment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleClassroomAssignment Assignment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}