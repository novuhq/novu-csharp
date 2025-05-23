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
    
    /// <summary>
    /// The Digest Type
    /// </summary>
    public enum DigestTypeEnum
    {
        [JsonProperty("regular")]
        Regular,
        [JsonProperty("backoff")]
        Backoff,
        [JsonProperty("timed")]
        Timed,
    }

    public static class DigestTypeEnumExtension
    {
        public static string Value(this DigestTypeEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DigestTypeEnum ToEnum(this string value)
        {
            foreach(var field in typeof(DigestTypeEnum).GetFields())
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

                    if (enumVal is DigestTypeEnum)
                    {
                        return (DigestTypeEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DigestTypeEnum");
        }
    }

}