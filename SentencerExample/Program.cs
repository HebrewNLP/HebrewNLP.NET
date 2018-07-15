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

            HebrewNLP.HebrewNLP.Password = "KWcaArVL8B35qKQ";

            List<string> options = Sentencer.Sentences("������ ����� - �� ��� ����� ��� ����� ����. ������ ����� ���� - ������ �� ������� ������� ����� ������ ���� ���� ���� ���� ������ ���� ������ ������� ����� ��� ������. ��� ���� ����� ������ ������ ��� ����� �� ������� ��������. ������ ������� ���� ���� ������� ������ �������� ������� ����� ��� �����, ���� ��� ����� ���� ���������� ���� �� ����� ������ �� �� ���� ����� �����, ��� ���� ����������� ��� ������ ����� ����.");

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
