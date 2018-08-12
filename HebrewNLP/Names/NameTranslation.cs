using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP
{
    public class NameTranslation
    {

        public const string NAME_TRANSLATION_ENDPOINT = "/service/names/translation";

        public class SoundexRequest
        {
            public string token;

            [JsonConverter(typeof(StringEnumConverter))]
            public Language type;

            public int threshold;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string[] words;
        }

        public enum Language
        {
            HEBREW,
        }

        public class ErrorResponse
        {
            public string error;
        }

        public static List<string> Translate(string name, Language language, int threshold = 1)
        {
            return Translate(new string[] { name }, language, threshold)[0];
        }

        public static List<List<string>> Translate(string[] names, Language language, int threshold = 1)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            SoundexRequest request = new SoundexRequest() { words = names, type= language, threshold = threshold, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(NAME_TRANSLATION_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

    }
}
