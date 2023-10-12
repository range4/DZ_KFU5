using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU5
{
    internal class Program
    {


        private static int[] GetVowelsAndСonsonantsCount(char[] text)
        {
            const string RUS_VOWELS = "аеёиоуыэюя";
            int[] vowelsAndСonsonantsCounters = new int[2] { 0, 0 };

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    if (RUS_VOWELS.Contains(char.ToLower(text[i]).ToString()))
                        vowelsAndСonsonantsCounters[0]++;
                    else
                        vowelsAndСonsonantsCounters[1]++;
                }
            }

            return vowelsAndСonsonantsCounters;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Тумаков упражнение 6.1");
            char[] inputFileText = File.ReadAllText(@"/Users/kaneki44/Projects/KFU5/KFU5/Task1.txt").ToCharArray();
            int[] inputTextVowelsAndСonsonantsCounters = GetVowelsAndСonsonantsCount(inputFileText);

            Console.WriteLine("Количество гласных букв в тексте: {0}", inputTextVowelsAndСonsonantsCounters[0]);
            Console.WriteLine("Количество согласных букв в тексте: {0}", inputTextVowelsAndСonsonantsCounters[1]);

            Console.ReadKey();


        }










    }
}

