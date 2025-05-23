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
    
    public class TriggerEventResponseDto
    {

        /// <summary>
        /// Indicates whether the trigger was acknowledged or not
        /// </summary>
        [JsonProperty("acknowledged")]
        public bool Acknowledged { get; set; } = default!;

        /// <summary>
        /// Status of the trigger
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; } = default!;

        /// <summary>
        /// In case of an error, this field will contain the error message(s)
        /// </summary>
        [JsonProperty("error")]
        public List<string>? Error { get; set; }

        /// <summary>
        /// The returned transaction ID of the trigger
        /// </summary>
        [JsonProperty("transactionId")]
        public string? TransactionId { get; set; }
    }
}