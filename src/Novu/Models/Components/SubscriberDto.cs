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
    
    public class SubscriberDto
    {

        /// <summary>
        /// The identifier of the subscriber
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The external identifier of the subscriber
        /// </summary>
        [JsonProperty("subscriberId")]
        public string SubscriberId { get; set; } = default!;

        /// <summary>
        /// The avatar URL of the subscriber
        /// </summary>
        [JsonProperty("avatar")]
        public string? Avatar { get; set; } = null;

        /// <summary>
        /// The first name of the subscriber
        /// </summary>
        [JsonProperty("firstName")]
        public string? FirstName { get; set; } = null;

        /// <summary>
        /// The last name of the subscriber
        /// </summary>
        [JsonProperty("lastName")]
        public string? LastName { get; set; } = null;

        /// <summary>
        /// The email of the subscriber
        /// </summary>
        [JsonProperty("email")]
        public string? Email { get; set; } = null;
    }
}