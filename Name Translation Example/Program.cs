using HebrewNLP;
using System;
using System.Collections.Generic;

namespace Name_Translation_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<string>> options = NameTranslation.Translate(new String[] { "haim", "haym" }, NameTranslation.Language.HEBREW);

            foreach (List<string> option in options)
            {
                Console.WriteLine(option.Count != 0 ? option[0] : null);
            }
        }
    }
}
