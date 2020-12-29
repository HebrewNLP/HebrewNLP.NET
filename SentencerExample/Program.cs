using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HebrewNLP;
using HebrewNLP.Preprocess;

namespace SentencerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO fill the password
            HebrewNLP.HebrewNLP.Password = "";


            List<string> res = HebrewNLP.Preprocess.Tokenizer.TokenizeSentence(".זה משפט ארוך מאןד הכולל הרבה מילים");
            foreach (string word in res)
            {
                Console.WriteLine(Reverse(word));
            }
            Console.WriteLine();
            Console.WriteLine();
            
            List<string> options = Sentencer.Sentences("התשובה הקצרה - כי אין תשתית כזו זמינה כיום. התשובה המלאה יותר - כקבוצה של מתכנתים העוסקים בתחום נאלצנו תמיד ללכת בדרך הקשה כשבאנו לפתח מוצרים הדורשים ניתוח שפה בעברית. וכך נוצר שיתוף הפעולה בעזרתו אנו בונים את השרותים והתשתיות. הציבור הישראלי תמיד סובל ממוצרים נחותים כשמגיעים ליכולות עיבוד שפה טבעית, למעט כמה יוצאי דופן הטכנולוגיה כמעט לא נגישה בעברית אם זה בגלל תמחור גבוהה, ואם מפני שהטכנולוגיה היא בשימוש פנימי בלבד.");

            foreach (string option in options)
            {
                Console.WriteLine(Reverse(option));
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
