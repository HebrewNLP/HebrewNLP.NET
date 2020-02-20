using System.Collections.Generic;
using HebrewNLP.Names;

namespace HebrewNLP
{
    public class NameTranslation
    {
        public const string NAME_TRANSLATION_ENDPOINT = "/service/names/translation";


        private static readonly Service<TranslationRequest> Service =
            new Service<TranslationRequest>(NAME_TRANSLATION_ENDPOINT);

        public static List<string> Translate(string name, Language language, int threshold = 1)
        {
            return Translate(new string[] {name}, language, threshold)[0];
        }

        public static List<List<string>> Translate(string[] names, Language language, int threshold = 1)
        {
            var request = new TranslationRequest {words = names, type = language, threshold = threshold};
            return Service.GetService<List<List<string>>>(request);
        }
    }
}