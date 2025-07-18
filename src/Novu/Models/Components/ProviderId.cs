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
    /// The ID of the chat or push provider.
    /// </summary>
    public enum ProviderId
    {
        [JsonProperty("slack")]
        Slack,
        [JsonProperty("discord")]
        Discord,
        [JsonProperty("msteams")]
        Msteams,
        [JsonProperty("mattermost")]
        Mattermost,
        [JsonProperty("ryver")]
        Ryver,
        [JsonProperty("zulip")]
        Zulip,
        [JsonProperty("grafana-on-call")]
        GrafanaOnCall,
        [JsonProperty("getstream")]
        Getstream,
        [JsonProperty("rocket-chat")]
        RocketChat,
        [JsonProperty("whatsapp-business")]
        WhatsappBusiness,
        [JsonProperty("chat-webhook")]
        ChatWebhook,
        [JsonProperty("fcm")]
        Fcm,
        [JsonProperty("apns")]
        Apns,
        [JsonProperty("expo")]
        Expo,
        [JsonProperty("one-signal")]
        OneSignal,
        [JsonProperty("pushpad")]
        Pushpad,
        [JsonProperty("push-webhook")]
        PushWebhook,
        [JsonProperty("pusher-beams")]
        PusherBeams,
    }

    public static class ProviderIdExtension
    {
        public static string Value(this ProviderId value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ProviderId ToEnum(this string value)
        {
            foreach(var field in typeof(ProviderId).GetFields())
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

                    if (enumVal is ProviderId)
                    {
                        return (ProviderId)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ProviderId");
        }
    }

}