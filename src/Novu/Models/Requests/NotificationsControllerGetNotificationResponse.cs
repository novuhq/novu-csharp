//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Novu.Models.Requests
{
    using Newtonsoft.Json;
    using Novu.Models.Components;
    using Novu.Utils;
    using System.Collections.Generic;
    
    public class NotificationsControllerGetNotificationResponse
    {

        [JsonProperty("-")]
        public HTTPMetadata HttpMeta { get; set; } = default!;

        /// <summary>
        /// OK
        /// </summary>
        public ActivityNotificationResponseDto? ActivityNotificationResponseDto { get; set; }

        public Dictionary<string, List<string>> Headers { get; set; } = default!;
    }
}