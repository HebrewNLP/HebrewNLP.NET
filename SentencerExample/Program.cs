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
            Console.OutputEncoding = new UTF8Encoding();
            Console.InputEncoding = new UTF8Encoding();

            HebrewNLP.HebrewNLP.Password = "...";

            List<string> options = Sentencer.Sentences("äúùåáä ä÷öøä - ëé àéï úùúéú ëæå æîéðä ëéåí. äúùåáä äîìàä éåúø - ë÷áåöä ùì îúëðúéí äòåñ÷éí áúçåí ðàìöðå úîéã ììëú áãøê ä÷ùä ëùáàðå ìôúç îåöøéí äãåøùéí ðéúåç ùôä áòáøéú. åëê ðåöø ùéúåó äôòåìä áòæøúå àðå áåðéí àú äùøåúéí åäúùúéåú. äöéáåø äéùøàìé úîéã ñåáì îîåöøéí ðçåúéí ëùîâéòéí ìéëåìåú òéáåã ùôä èáòéú, ìîòè ëîä éåöàé ãåôï äèëðåìåâéä ëîòè ìà ðâéùä áòáøéú àí æä áâìì úîçåø âáåää, åàí îôðé ùäèëðåìåâéä äéà áùéîåù ôðéîé áìáã.");

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
