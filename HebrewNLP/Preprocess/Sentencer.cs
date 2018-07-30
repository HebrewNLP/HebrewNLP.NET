using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP.Preprocess
{
    public class Sentencer
    {

        public const string PREPROCESS_SENTENCER_ENDPOINT = "/service/preprocess/sentencer";

        public class SentencerRequest
        {
            public string text;
            public string token;
        }

        public class ErrorResponse
        {
            public string error;
        }

        public static List<string> Sentences(string text)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            SentencerRequest request = new SentencerRequest() { text = text, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(PREPROCESS_SENTENCER_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<string>>(responseJson);
        }

    }
}
