using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP.Preprocess
{
    public class Sentencer
    {

        public const string PREPROCESS_SENTENCER_ENDPOINT = "/service/preprocess/sentencer";

        public class MorphRequest
        {
            public string text;
            public string token;
        }

        public class MorphErrorResponse
        {
            public string error;
        }

        public static List<string> Sentences(string text)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { text = text, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(PREPROCESS_SENTENCER_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<string>>(responseJson);
        }

    }
}
