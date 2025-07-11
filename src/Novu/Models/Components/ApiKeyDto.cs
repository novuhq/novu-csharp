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
    
    public class ApiKeyDto
    {

        /// <summary>
        /// API key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = default!;

        /// <summary>
        /// User ID associated with the API key
        /// </summary>
        [JsonProperty("_userId")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Hashed representation of the API key
        /// </summary>
        [JsonProperty("hash")]
        public string? Hash { get; set; }
    }
}