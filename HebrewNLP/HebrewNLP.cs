using System;
using System.Diagnostics;

namespace HebrewNLP
{
    public class HebrewNLP
    {
        //TODO fill here your password
        private static string password = null;

        public static string Password
        {
            set => password = value;
            get
            {
                if (!string.IsNullOrEmpty(password))
                    return password;
                const string url = "https://hebrew-nlp.co.il/registration";

                var message = $@"Please set HebrewNLP.Password property with your password before using this method.
 To get a password register at {url} .
(The program will open the browser automaticaly)";
                Console.Error.WriteLine(message);
                Console.Error.WriteLine();
                new Process {StartInfo = {UseShellExecute = true, FileName = url}}.Start();

                var messageException =
                    $@"Cannot use the service without initialising HebrewNLP.Password property with your password.
 To get a password register at {url} .";
                throw new InvalidOperationException(messageException);
            }
        }
    }
}