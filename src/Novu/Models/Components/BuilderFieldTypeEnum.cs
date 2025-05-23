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
    
    public enum BuilderFieldTypeEnum
    {
        [JsonProperty("BOOLEAN")]
        Boolean,
        [JsonProperty("TEXT")]
        Text,
        [JsonProperty("DATE")]
        Date,
        [JsonProperty("NUMBER")]
        Number,
        [JsonProperty("STATEMENT")]
        Statement,
        [JsonProperty("LIST")]
        List,
        [JsonProperty("MULTI_LIST")]
        MultiList,
        [JsonProperty("GROUP")]
        Group,
    }

    public static class BuilderFieldTypeEnumExtension
    {
        public static string Value(this BuilderFieldTypeEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static BuilderFieldTypeEnum ToEnum(this string value)
        {
            foreach(var field in typeof(BuilderFieldTypeEnum).GetFields())
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

                    if (enumVal is BuilderFieldTypeEnum)
                    {
                        return (BuilderFieldTypeEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum BuilderFieldTypeEnum");
        }
    }

}