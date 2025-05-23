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
    
    public class NotificationStepData
    {

        /// <summary>
        /// Unique identifier for the notification step.
        /// </summary>
        [JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Universally unique identifier for the notification step.
        /// </summary>
        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Name of the notification step.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the template associated with this notification step.
        /// </summary>
        [JsonProperty("_templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Indicates whether the notification step is active.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Determines if the process should stop on failure.
        /// </summary>
        [JsonProperty("shouldStopOnFail")]
        public bool? ShouldStopOnFail { get; set; }

        /// <summary>
        /// Message template used in this notification step.
        /// </summary>
        [JsonProperty("template")]
        public MessageTemplate? Template { get; set; }

        /// <summary>
        /// Filters applied to this notification step.
        /// </summary>
        [JsonProperty("filters")]
        public List<StepFilterDto>? Filters { get; set; }

        /// <summary>
        /// ID of the parent notification step, if applicable.
        /// </summary>
        [JsonProperty("_parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Metadata associated with the workflow step. Can vary based on the type of step.
        /// </summary>
        [JsonProperty("metadata")]
        public NotificationStepDataMetadata? Metadata { get; set; }

        /// <summary>
        /// Callback information for replies, including whether it is active and the callback URL.
        /// </summary>
        [JsonProperty("replyCallback")]
        public ReplyCallback? ReplyCallback { get; set; }
    }
}