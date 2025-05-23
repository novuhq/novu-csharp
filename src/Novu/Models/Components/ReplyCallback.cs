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
    using Novu.Utils;
    
    public class ReplyCallback
    {

        /// <summary>
        /// Indicates whether the reply callback is active.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The URL to which replies should be sent.
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}