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
    
    public class ActivityNotificationExecutionDetailResponseDto
    {

        /// <summary>
        /// Unique identifier of the execution detail
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Creation time of the execution detail
        /// </summary>
        [JsonProperty("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Status of the execution detail
        /// </summary>
        [JsonProperty("status")]
        public ExecutionDetailsStatusEnum Status { get; set; } = default!;

        /// <summary>
        /// Detailed information about the execution
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; } = default!;

        /// <summary>
        /// Whether the execution is a retry or not
        /// </summary>
        [JsonProperty("isRetry")]
        public bool IsRetry { get; set; } = default!;

        /// <summary>
        /// Whether the execution is a test or not
        /// </summary>
        [JsonProperty("isTest")]
        public bool IsTest { get; set; } = default!;

        /// <summary>
        /// Provider ID of the job
        /// </summary>
        [JsonProperty("providerId")]
        public ProvidersIdEnum ProviderId { get; set; } = default!;

        /// <summary>
        /// Raw data of the execution
        /// </summary>
        [JsonProperty("raw")]
        public string? Raw { get; set; } = null;

        /// <summary>
        /// Source of the execution detail
        /// </summary>
        [JsonProperty("source")]
        public ExecutionDetailsSourceEnum Source { get; set; } = default!;
    }
}