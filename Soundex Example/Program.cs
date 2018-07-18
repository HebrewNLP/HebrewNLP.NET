using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundex_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            HebrewNLP.HebrewNLP.Password = "...";

            string[] words = new string[] { "itay", "איתי" };
            List<List<string>> phoneticCodes = HebrewNLP.Soundexer.Soundex(words);
            bool found = false;
            string code = null;
            Console.WriteLine(words[0] + ":");
            foreach (string str in phoneticCodes[0])
            {
                Console.WriteLine("\t" + str);
                if(phoneticCodes[1].Contains(str))
                {
                    found = true;
                    code = str;
                    break;
                }
            }

            Console.WriteLine(words[1] + ":");
            foreach (string str in phoneticCodes[1])
            {
                Console.WriteLine("\t" + str);
            }

            Console.WriteLine();

            if (found)
            {
                Console.WriteLine("words are probably the same (" + code + ")");
            }else
            {
                Console.WriteLine("words are probably different");
            }
        }
    }
}
