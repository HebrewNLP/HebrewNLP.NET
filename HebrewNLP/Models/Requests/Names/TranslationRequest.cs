
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HebrewNLP.Names
{
    public class TranslationRequest : BaseRequest
    {

        [JsonConverter(typeof(StringEnumConverter))]
        public Language type;

        public string[] words;

        public int threshold;

    }
}