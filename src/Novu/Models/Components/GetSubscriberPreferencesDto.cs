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
    using System.Collections.Generic;
    
    public class GetSubscriberPreferencesDto
    {

        /// <summary>
        /// Global preference settings
        /// </summary>
        [JsonProperty("global")]
        public SubscriberGlobalPreferenceDto Global { get; set; } = default!;

        /// <summary>
        /// Workflow-specific preference settings
        /// </summary>
        [JsonProperty("workflows")]
        public List<SubscriberWorkflowPreferenceDto> Workflows { get; set; } = default!;
    }
}