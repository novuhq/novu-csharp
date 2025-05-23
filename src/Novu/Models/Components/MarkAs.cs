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
    /// Mark all subscriber messages as read, unread, seen or unseen
    /// </summary>
    public enum MarkAs
    {
        [JsonProperty("read")]
        Read,
        [JsonProperty("seen")]
        Seen,
        [JsonProperty("unread")]
        Unread,
        [JsonProperty("unseen")]
        Unseen,
    }

    public static class MarkAsExtension
    {
        public static string Value(this MarkAs value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static MarkAs ToEnum(this string value)
        {
            foreach(var field in typeof(MarkAs).GetFields())
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

                    if (enumVal is MarkAs)
                    {
                        return (MarkAs)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum MarkAs");
        }
    }

}