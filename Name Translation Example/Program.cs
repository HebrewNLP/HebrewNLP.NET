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
            HebrewNLP.HebrewNLP.Password = "hwYQWyc37oOAVXm";


            List<List<string>> res = HebrewNLP.Preprocess.Tokenizer.TokenizeSentence(".זה משפט ארוך מאןד הכולל הרבה מילים");

            Console.Write(res.Count);
        }
    }
}
