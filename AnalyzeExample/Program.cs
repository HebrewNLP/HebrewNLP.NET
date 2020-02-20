using System;
using System.Collections.Generic;
using System.Text;
using HebrewNLP.Morphology;

namespace AnalyzeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO fill the password
            HebrewNLP.HebrewNLP.Password = "";

            Console.OutputEncoding = new UTF8Encoding();
            Console.InputEncoding = new UTF8Encoding();


            List<MorphInfo> options = HebrewMorphology.AnalyzeWord("מילה");

            int i = 0;
            foreach (MorphInfo option in options)
            {
                Console.WriteLine("Option " + (++i) + ":");
                Console.WriteLine(ObjectDumper.Dump(option));
            }
        }
    }
}
