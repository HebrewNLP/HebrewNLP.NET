using System.Collections.Generic;

namespace HebrewNLP.Names
{
    public class NameAnalyzer
    {
        public const string NAME_TRANSLATION_ENDPOINT = "/service/names/translation";

        private static readonly Service<NamesAnalyzeRequest> Service =
            new Service<NamesAnalyzeRequest>(NAME_TRANSLATION_ENDPOINT);

        public static List<NameInfo> Analyze(string[] names)
        {
            return Service.GetService<List<NameInfo>>(new NamesAnalyzeRequest {names = names});
        }
    }
}