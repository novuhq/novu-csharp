//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Novu.Models.Components
{
    using Newtonsoft.Json;
    using Novu.Models.Components;
    using Novu.Utils;
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// This could be used to override provider specific configurations
    /// </summary>
    public class Overrides
    {

        /// <summary>
        /// This could be used to override provider specific configurations
        /// </summary>
        [JsonProperty("steps")]
        public Dictionary<string, StepsOverrides>? Steps { get; set; }

        /// <summary>
        /// Overrides the provider configuration for the entire workflow and all steps
        /// </summary>
        [JsonProperty("providers")]
        public Dictionary<string, Dictionary<string, object>>? Providers { get; set; }

        /// <summary>
        /// Override the email provider specific configurations for the entire workflow
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("email")]
        public Dictionary<string, object>? Email { get; set; }

        /// <summary>
        /// Override the push provider specific configurations for the entire workflow
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("push")]
        public Dictionary<string, object>? Push { get; set; }

        /// <summary>
        /// Override the sms provider specific configurations for the entire workflow
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("sms")]
        public Dictionary<string, object>? Sms { get; set; }

        /// <summary>
        /// Override the chat provider specific configurations for the entire workflow
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("chat")]
        public Dictionary<string, object>? Chat { get; set; }

        /// <summary>
        /// Override the layout identifier for the entire workflow
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("layoutIdentifier")]
        public string? LayoutIdentifier { get; set; }
    }
}