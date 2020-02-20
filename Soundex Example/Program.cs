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
            //TODO fill the password
            HebrewNLP.HebrewNLP.Password = "";

            string[] words = new string[] {"itay", "איתי"};
            List<List<uint>> phoneticCodes = HebrewNLP.Soundexer.Soundex(words);
            bool found = false;
            uint? code = null;
            Console.WriteLine(words[0] + ":");
            foreach (var i in phoneticCodes[0])
            {
                Console.WriteLine("\t" + i);
                if (!found && phoneticCodes[1].Contains(i))
                {
                    found = true;
                    code = i;
                }
            }

            Console.WriteLine(words[1] + ":");
            foreach (var i in phoneticCodes[1])
            {
                Console.WriteLine("\t" + i);
            }

            Console.WriteLine();

            if (found)
            {
                Console.WriteLine("words are probably the same (" + code + ")");
            }
            else
            {
                Console.WriteLine("words are probably different");
            }
        }
    }
}