using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishWordHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<string> words = new List<string>();

            words.Add("Responsible - ");
            words.Add("Quick-tempered - ");
            words.Add("Generous - ");
            words.Add("Clever - ");
            words.Add("Affectionate - ");

            Console.WriteLine();
            //foreach(String word in words)
            //{
            //    Console.WriteLine(word);
            //}

            List<string> translateWord = new List<string>();

            translateWord.Add("Відповідальній");
            translateWord.Add("Вспильчевий");
            translateWord.Add("Великодушній");
            translateWord.Add("Розумний");
            translateWord.Add("Ніжний");

            Console.WriteLine();

            
            //foreach(String translatedWord in translateWord)
            //{
            //    Console.WriteLine(translatedWord);
            //}
            
            //Генератор випадкових слів зі списку
            Random randomWord = new Random();
            switch (randomWord.Next(5))
            {
                case 1:
                    Console.Write(words[0]);
                    Console.Write(translateWord[0]);
                    break;
                case 2:
                    Console.Write(words[1]);
                    Console.Write(translateWord[1]);
                    break;
                case 3:
                    Console.Write(words[2]);
                    Console.Write(translateWord[2]);
                    break;
                case 4:
                    Console.Write(words[3]);
                    Console.Write(translateWord[3]);
                    break;
                case 5:
                    Console.Write(words[4]);
                    Console.Write(translateWord[4]);
                    break;
            }

            //String translate = Console.ReadLine();
            //String rWord = randomWord.ToString();
            ////String tWord = translateWord.ToString();

            ////if (rWord == tWord)
            ////{
            //    for (int i = 0; i <= translateWord.Count; i++)
            //    {
            //        if (translate == translateWord[i])
            //        {
            //            Console.WriteLine("Good!!!");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong!");
            //            break;
            //        }
            //    }
            ////}

          

            Console.ReadKey();
        }        
    }
}
