using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP
{
    public class Soundexer
    {

        public const string SOUNDEX_ENDPOINT = "/service/soundex";

        public class SoundexRequest
        {
            public string token;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string[] words;
        }

        public class ErrorResponse
        {
            public string error;
        }

        public static List<List<string>> Soundex(string[] words)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            SoundexRequest request = new SoundexRequest() { words = words, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(SOUNDEX_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

    }
}
