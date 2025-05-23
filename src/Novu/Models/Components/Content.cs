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
    using Newtonsoft.Json.Linq;
    using Novu.Models.Components;
    using Novu.Utils;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class ContentType
    {
        private ContentType(string value) { Value = value; }

        public string Value { get; private set; }
        public static ContentType ArrayOfEmailBlock { get { return new ContentType("arrayOfEmailBlock"); } }
        
        public static ContentType Str { get { return new ContentType("str"); } }
        
        public static ContentType Null { get { return new ContentType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ContentType v) { return v.Value; }
        public static ContentType FromString(string v) {
            switch(v) {
                case "arrayOfEmailBlock": return ArrayOfEmailBlock;
                case "str": return Str;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ContentType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ContentType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// Content of the message, can be an email block or a string
    /// </summary>
    [JsonConverter(typeof(Content.ContentConverter))]
    public class Content {
        public Content(ContentType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public List<EmailBlock>? ArrayOfEmailBlock { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        public ContentType Type { get; set; }


        public static Content CreateArrayOfEmailBlock(List<EmailBlock> arrayOfEmailBlock) {
            ContentType typ = ContentType.ArrayOfEmailBlock;

            Content res = new Content(typ);
            res.ArrayOfEmailBlock = arrayOfEmailBlock;
            return res;
        }

        public static Content CreateStr(string str) {
            ContentType typ = ContentType.Str;

            Content res = new Content(typ);
            res.Str = str;
            return res;
        }

        public static Content CreateNull() {
            ContentType typ = ContentType.Null;
            return new Content(typ);
        }

        public class ContentConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(Content);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new Content(ContentType.ArrayOfEmailBlock)
                    {
                        ArrayOfEmailBlock = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<EmailBlock>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<EmailBlock>), new Content(ContentType.ArrayOfEmailBlock), "ArrayOfEmailBlock"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (json[0] == '"' && json[^1] == '"'){
                    return new Content(ContentType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                Content res = (Content)value;
                if (ContentType.FromString(res.Type).Equals(ContentType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfEmailBlock != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfEmailBlock));
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }

            }

        }

    }
}