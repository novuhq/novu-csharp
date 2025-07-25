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
    /// The type of digest strategy. Determines which fields are applicable.
    /// </summary>
    public enum DigestControlDtoType
    {
        [JsonProperty("regular")]
        Regular,
        [JsonProperty("timed")]
        Timed,
    }

    public static class DigestControlDtoTypeExtension
    {
        public static string Value(this DigestControlDtoType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DigestControlDtoType ToEnum(this string value)
        {
            foreach(var field in typeof(DigestControlDtoType).GetFields())
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

                    if (enumVal is DigestControlDtoType)
                    {
                        return (DigestControlDtoType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DigestControlDtoType");
        }
    }

}