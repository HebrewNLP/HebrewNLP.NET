using HebrewNLP;
using System;
using System.Collections.Generic;
using HebrewNLP.Names;

namespace Name_Translation_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO fill the password
            HebrewNLP.HebrewNLP.Password = "";
            
            List<List<string>> options = NameTranslation.Translate(new String[] { "haim", "haym" }, Language.HEBREW);

            foreach (List<string> option in options)
            {
                Console.WriteLine(option.Count != 0 ? option[0] : null);
            }
        }
    }
}
