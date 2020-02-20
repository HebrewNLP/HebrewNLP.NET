using System.Collections.Generic;

namespace HebrewNLP.Morphology
{
    public class HebrewMorphology
    {
        public const string MORPH_NORMALIZE_ENDPOINT = "/service/morphology/normalize";
        public const string MORPH_ANALYZE_ENDPOINT = "/service/morphology/analyze";

        #region Analyze

        private static readonly Service<AnalyzeRequest> Analyzer =
            new Service<AnalyzeRequest>(MORPH_ANALYZE_ENDPOINT);

        public static List<List<List<MorphInfo>>> AnalyzeText(string text)
        {
            return Analyzer.GetService<List<List<List<MorphInfo>>>>(new AnalyzeRequest() {paragraph = text});
        }

        public static List<List<List<MorphInfo>>> AnalyzeSentences(string[] sentences)
        {
            return Analyzer.GetService<List<List<List<MorphInfo>>>>(
                new AnalyzeRequest() {sentences = sentences});
        }

        public static List<List<MorphInfo>> AnalyzeSentence(string sentence)
        {
            return Analyzer.GetService<List<List<MorphInfo>>>(new AnalyzeRequest() {sentence = sentence});
        }

        public static List<List<MorphInfo>> AnalyzeWords(string[] words)
        {
            return Analyzer.GetService<List<List<MorphInfo>>>(new AnalyzeRequest() {words = words});
        }

        public static List<MorphInfo> AnalyzeWord(string word)
        {
            return AnalyzeWords(new string[] {word})[0];
        }

        #endregion

        #region Normalize

        private static readonly Service<NormalizeRequest> Normaliser =
            new Service<NormalizeRequest>(MORPH_NORMALIZE_ENDPOINT);

        public static List<List<string>> NormalizeText(string text, NormalizationType type = NormalizationType.SEARCH)
        {
            return Normaliser.GetService<List<List<string>>>(new NormalizeRequest() {text = text});
        }

        public static List<List<string>> NormalizeSentences(string[] sentences,
            NormalizationType type = NormalizationType.SEARCH)
        {
            return Normaliser.GetService<List<List<string>>>(
                new NormalizeRequest() {sentences = sentences, type = type});
        }

        public static List<string> NormalizeSentence(string sentence, NormalizationType type = NormalizationType.SEARCH)
        {
            return Normaliser.GetService<List<string>>(new NormalizeRequest() {sentence = sentence, type = type});
        }

        public static List<string> NormalizeWords(string[] words, NormalizationType type = NormalizationType.SEARCH)
        {
            return Normaliser.GetService<List<string>>(new NormalizeRequest() {words = words, type = type});
        }

        public static string NormalizeWord(string word, NormalizationType type)
        {
            return NormalizeWords(new string[] {word}, type)[0];
        }

        #endregion
    }
}