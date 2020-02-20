using System.Collections.Generic;
using Newtonsoft.Json;

namespace HebrewNLP.Website.Services.Requests
{
    public class NerCitiesRequest : BaseRequest
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string text;
 
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] sentences;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string sentence;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] words;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string[] categories;
    }
}