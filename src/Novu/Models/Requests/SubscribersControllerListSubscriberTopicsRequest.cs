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
    using Novu.Models.Requests;
    using Novu.Utils;
    
    public class SubscribersControllerListSubscriberTopicsRequest
    {

        /// <summary>
        /// The identifier of the subscriber
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=subscriberId")]
        public string SubscriberId { get; set; } = default!;

        /// <summary>
        /// Cursor for pagination indicating the starting point after which to fetch results.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=after")]
        public string? After { get; set; }

        /// <summary>
        /// Cursor for pagination indicating the ending point before which to fetch results.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=before")]
        public string? Before { get; set; }

        /// <summary>
        /// Limit the number of items to return (max 100)
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Direction of sorting
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=orderDirection")]
        public QueryParamOrderDirection? OrderDirection { get; set; }

        /// <summary>
        /// Field to order by
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Include cursor item in response
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=includeCursor")]
        public bool? IncludeCursor { get; set; }

        /// <summary>
        /// Filter by topic key
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=key")]
        public string? Key { get; set; }

        /// <summary>
        /// A header for idempotency purposes
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=idempotency-key")]
        public string? IdempotencyKey { get; set; }
    }
}