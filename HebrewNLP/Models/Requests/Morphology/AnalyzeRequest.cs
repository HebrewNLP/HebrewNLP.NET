using Newtonsoft.Json;

namespace HebrewNLP.Morphology
{
    public class AnalyzeRequest : BaseRequest
    {

        public bool readable = false;
    
        public bool best = false;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string paragraph;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] sentences;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string sentence;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] words;

    }
}