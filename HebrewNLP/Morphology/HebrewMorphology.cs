using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP.Morphology
{
    public class HebrewMorphology
    {

        public const string MORPH_NORMALIZE_ENDPOINT = "/service/morphology/normalize";
        public const string MORPH_ANALYZE_ENDPOINT = "/service/morphology/analyze";

        public class MorphRequest
        {
            public string token;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string[] words;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string sentence;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string[] sentences;

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public string text;

        }

        public class MorphErrorResponse
        {
            public string error;
        }

        #region Analyze

        public static List<List<List<MorphInfo>>> AnalyzeText(string text)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { text = text, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_ANALYZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<List<MorphInfo>>>>(responseJson);
        }

        public static List<List<List<MorphInfo>>> AnalyzeSentences(string[] sentences)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { sentences = sentences, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_ANALYZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject< List<List<List<MorphInfo>>>>(responseJson);
        }

        public static List<List<MorphInfo>> AnalyzeSentence(string sentence)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { sentence = sentence, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_ANALYZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<MorphInfo>>>(responseJson);
        }

        public static List<List<MorphInfo>> AnalyzeWords(string[] words)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { words = words, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_ANALYZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<MorphInfo>>>(responseJson);
        }

        public static List<MorphInfo> AnalyzeWord(string word)
        {
            return AnalyzeWords(new string[] { word })[0];
        }

        #endregion

        #region Normalize

        public static List<List<string>> NormalizeText(string text)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { text = text, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

        public static List<List<string>> NormalizeSentences(string[] sentences)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { sentences = sentences, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

        public static List<string> NormalizeSentence(string sentence)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { sentence = sentence, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<string>>(responseJson);
        }

        public static List<string> NormalizeWords(string[] words)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { words = words, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<string>>(responseJson);
        }

        public static string NormalizeWord(string word)
        {
            return NormalizeWords(new string[] { word })[0];
        }

        #endregion

    }
}
