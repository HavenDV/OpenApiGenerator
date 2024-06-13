﻿//HintName: G.Models.CodeOfConduct.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code Of Conduct
    /// </summary>
    public sealed partial class CodeOfConduct
    {
        /// <summary>
        /// Example: contributor_covenant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Example: Contributor Covenant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/codes_of_conduct/contributor_covenant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: # Contributor Covenant Code of Conduct<br/>
        /// ## Our Pledge<br/>
        /// In the interest of fostering an open and welcoming environment, we as contributors and maintainers pledge to making participation in our project and our community a harassment-free experience for everyone, regardless of age, body size, disability, ethnicity, gender identity and expression, level of experience, nationality, personal appearance, race, religion, or sexual identity and orientation.<br/>
        /// ## Our Standards<br/>
        /// Examples of behavior that contributes to creating a positive environment include:<br/>
        /// * Using welcoming and inclusive language<br/>
        /// * Being respectful of differing viewpoints and experiences<br/>
        /// * Gracefully accepting constructive criticism<br/>
        /// * Focusing on what is best for the community<br/>
        /// * Showing empathy towards other community members<br/>
        /// Examples of unacceptable behavior by participants include:<br/>
        /// * The use of sexualized language or imagery and unwelcome sexual attention or advances<br/>
        /// * Trolling, insulting/derogatory comments, and personal or political attacks<br/>
        /// * Public or private harassment<br/>
        /// * Publishing others' private information, such as a physical or electronic address, without explicit permission<br/>
        /// * Other conduct which could reasonably be considered inappropriate in a professional setting<br/>
        /// ## Our Responsibilities<br/>
        /// Project maintainers are responsible for clarifying the standards of acceptable behavior and are expected to take appropriate and fair corrective action in response<br/>
        ///                   to any instances of unacceptable behavior.<br/>
        /// Project maintainers have the right and responsibility to remove, edit, or reject comments, commits, code, wiki edits, issues, and other contributions that are not aligned to this Code of Conduct, or to ban temporarily or permanently any contributor for other behaviors that they deem inappropriate, threatening, offensive, or harmful.<br/>
        /// ## Scope<br/>
        /// This Code of Conduct applies both within project spaces and in public spaces when an individual is representing the project or its community. Examples of representing a project or community include using an official project e-mail address,<br/>
        ///                   posting via an official social media account, or acting as an appointed representative at an online or offline event. Representation of a project may be further defined and clarified by project maintainers.<br/>
        /// ## Enforcement<br/>
        /// Instances of abusive, harassing, or otherwise unacceptable behavior may be reported by contacting the project team at [EMAIL]. The project team will review and investigate all complaints, and will respond in a way that it deems appropriate to the circumstances. The project team is obligated to maintain confidentiality with regard to the reporter of an incident. Further details of specific enforcement policies may be posted separately.<br/>
        /// Project maintainers who do not follow or enforce the Code of Conduct in good faith may face temporary or permanent repercussions as determined by other members of the project's leadership.<br/>
        /// ## Attribution<br/>
        /// This Code of Conduct is adapted from the [Contributor Covenant](http://contributor-covenant.org), version 1.4, available at [http://contributor-covenant.org/version/1/4](http://contributor-covenant.org/version/1/4/).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}