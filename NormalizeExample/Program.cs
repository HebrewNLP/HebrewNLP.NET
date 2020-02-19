using HebrewNLP.Morphology;
using System;
using System.Collections.Generic;
using System.Text;

namespace NormalizeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = new UTF8Encoding();
            Console.InputEncoding = new UTF8Encoding();


            List<string> options = HebrewMorphology.NormalizeSentence("הילד שהלך לפרק ישב", HebrewMorphology.NormalizationType.INDEX);

            foreach (string option in options)
            {
                Console.Write(Reverse(option) + " ");
            }
            Console.WriteLine();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
