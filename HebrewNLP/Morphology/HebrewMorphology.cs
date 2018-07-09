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
            public string[] words;
            public string token;
        }

        public class MorphErrorResponse
        {
            public string error;
        }

        public static List<string> NormalizeWords(string[] words)
        {
            if(string.IsNullOrEmpty(HebrewNLP.Password))
            {
                throw new InvalidOperationException("Please set HebrewNLP.Password property with your password before using this method");
            }
            MorphRequest request = new MorphRequest() { words = words, token = HebrewNLP.Password };
            string requestJson = JsonConvert.SerializeObject(request);
            string responseJson = Util.PostJSONData(MORPH_NORMALIZE_ENDPOINT, requestJson);
            if(responseJson.StartsWith("{\"error\":"))
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

    }
}
