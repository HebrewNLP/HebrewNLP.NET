using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP.Preprocess
{
    public class Tokenizer
    {

        public const string PREPROCESS_TOKENIZER_ENDPOINT = "/service/preprocess/tokenizer";

        public class SentencerRequest
        {
            public string token;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string text;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string[] sentences;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string sentence;
        }

        public class ErrorResponse
        {
            public string error;
        }

        public static List<List<string>> TokenizeText(string text)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            SentencerRequest request = new SentencerRequest() { text = text, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(PREPROCESS_TOKENIZER_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

        public static List<List<string>> TokenizeSentences(string[] sentences)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            SentencerRequest request = new SentencerRequest() { sentences = sentences, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(PREPROCESS_TOKENIZER_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

        public static List<string> TokenizeSentence(string sentence)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            SentencerRequest request = new SentencerRequest() { sentence = sentence, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(PREPROCESS_TOKENIZER_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                ErrorResponse error = JsonConvert.DeserializeObject<ErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<string>>(responseJson);
        }

    }
}
