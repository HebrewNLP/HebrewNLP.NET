using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP.Names
{
    public class NameAnalyzer
    {

        public const string NAME_TRANSLATION_ENDPOINT = "/service/names/translation";

        public class SoundexRequest
        {
            public string token;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string[] names;
        }

        public class ErrorResponse
        {
            public string error;
        }

        public static List<NameInfo> Analyze(string[] names)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            SoundexRequest request = new SoundexRequest() { names = names, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(NAME_TRANSLATION_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<NameInfo>>(responseJson);
        }

    }
}
