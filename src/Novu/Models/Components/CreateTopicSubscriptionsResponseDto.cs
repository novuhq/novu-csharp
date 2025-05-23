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
    
    public class CreateTopicSubscriptionsResponseDto
    {

        /// <summary>
        /// The list of successfully created subscriptions
        /// </summary>
        [JsonProperty("data")]
        public List<SubscriptionDto> Data { get; set; } = default!;

        /// <summary>
        /// Metadata about the operation
        /// </summary>
        [JsonProperty("meta")]
        public MetaDto Meta { get; set; } = default!;

        /// <summary>
        /// The list of errors for failed subscription attempts
        /// </summary>
        [JsonProperty("errors")]
        public List<SubscriptionErrorDto>? Errors { get; set; }
    }
}