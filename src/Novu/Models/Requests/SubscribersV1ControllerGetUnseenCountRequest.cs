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
    using Novu.Utils;
    
    public class SubscribersV1ControllerGetUnseenCountRequest
    {

        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=subscriberId")]
        public string SubscriberId { get; set; } = default!;

        /// <summary>
        /// Indicates whether to count seen notifications.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=seen")]
        public bool? Seen { get; set; } = false;

        /// <summary>
        /// The maximum number of notifications to return.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public double? Limit { get; set; } = 100D;

        /// <summary>
        /// A header for idempotency purposes
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=idempotency-key")]
        public string? IdempotencyKey { get; set; }
    }
}