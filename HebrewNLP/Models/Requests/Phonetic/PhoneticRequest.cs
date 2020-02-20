using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HebrewNLP.Website.Services.Requests
{
    public class PhoneticRequest : BaseRequest
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public UIPhoneticType type;

        public string[] words;
    }
}