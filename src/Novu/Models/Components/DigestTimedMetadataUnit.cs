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
    using System;
    
    public enum DigestTimedMetadataUnit
    {
        [JsonProperty("seconds")]
        Seconds,
        [JsonProperty("minutes")]
        Minutes,
        [JsonProperty("hours")]
        Hours,
        [JsonProperty("days")]
        Days,
        [JsonProperty("weeks")]
        Weeks,
        [JsonProperty("months")]
        Months,
    }

    public static class DigestTimedMetadataUnitExtension
    {
        public static string Value(this DigestTimedMetadataUnit value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DigestTimedMetadataUnit ToEnum(this string value)
        {
            foreach(var field in typeof(DigestTimedMetadataUnit).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is DigestTimedMetadataUnit)
                    {
                        return (DigestTimedMetadataUnit)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DigestTimedMetadataUnit");
        }
    }

}