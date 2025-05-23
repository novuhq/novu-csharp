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
    
    public class TopicDto
    {

        /// <summary>
        /// The internal unique identifier of the topic
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The key identifier of the topic used in your application. Should be unique on the environment level.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The name of the topic
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}