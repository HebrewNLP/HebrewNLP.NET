using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace HebrewNLP.Morphology
{
    public class HebrewMorphology
    {

        public const string MORPH_NORMALIZE_ENDPOINT = "/service/morphology/normalize";
        public const string MORPH_ANALYZE_ENDPOINT = "/service/morphology/analyze";

        public enum NormalizationType
        {
            SEARCH,
            INDEX
        }

        public class AnalyzeRequest
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

        public class NormalizationRequest
        {
            public string token;

            [JsonConverter(typeof(StringEnumConverter))]
            public NormalizationType type;

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
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            AnalyzeRequest request = new AnalyzeRequest() { text = text, token = HebrewNLP.Password };
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
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            AnalyzeRequest request = new AnalyzeRequest() { sentences = sentences, token = HebrewNLP.Password };
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
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            AnalyzeRequest request = new AnalyzeRequest() { sentence = sentence, token = HebrewNLP.Password };
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
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            AnalyzeRequest request = new AnalyzeRequest() { words = words, token = HebrewNLP.Password };
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

        public static List<List<string>> NormalizeText(string text, NormalizationType type = NormalizationType.SEARCH)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            NormalizationRequest request = new NormalizationRequest() { text = text, type = type, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

        public static List<List<string>> NormalizeSentences(string[] sentences, NormalizationType type = NormalizationType.SEARCH)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            NormalizationRequest request = new NormalizationRequest() { sentences = sentences, type = type, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<List<string>>>(responseJson);
        }

        public static List<string> NormalizeSentence(string sentence, NormalizationType type = NormalizationType.SEARCH)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            NormalizationRequest request = new NormalizationRequest() { sentence = sentence, type = type, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<string>>(responseJson);
        }

        public static List<string> NormalizeWords(string[] words, NormalizationType type = NormalizationType.SEARCH)
        {
            if (string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method. To get a password register at https://hebrew-nlp.co.il/registration.");
            }
            NormalizationRequest request = new NormalizationRequest() { words = words, type = type, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if (responseJson.StartsWith("{\"error\":"))
            {
                MorphErrorResponse error = JsonConvert.DeserializeObject<MorphErrorResponse>(responseJson);
                throw new Exception(error.error);
            }
            return JsonConvert.DeserializeObject<List<string>>(responseJson);
        }

        public static string NormalizeWord(string word, NormalizationType type)
        {
            return NormalizeWords(new string[] { word }, type)[0];
        }

        #endregion

    }
}
