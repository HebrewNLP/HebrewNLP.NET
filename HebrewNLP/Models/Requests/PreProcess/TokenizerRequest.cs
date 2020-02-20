using Newtonsoft.Json;

namespace HebrewNLP.Preprocess
{
    public class TokenizerRequest : BaseRequest
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string text;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] sentences;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string sentence;

    }
}