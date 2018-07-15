using System;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace StringCompression1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(StringCompression("aabcccccaaa"));
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
        public static string StringCompression(string word)
        {
            char word2 = word[0];
            bool finished = false;
            int number = 0;
            int x = 0;
            StringBuilder myString = new StringBuilder();


            while(!finished)
            {
                   
                if(word2!=word[x])
                {
                    myString.Append(word2);
                    myString.Append(number);

                    word2 = word[x];
                    number = 0;
                }
                x++;
                number++;
                if (x == word.Length)
                {
                    finished = true;
                    myString.Append(word2);
                    myString.Append(number);
                }
            }
            if (myString.Length > word.Length)
            {
                return word;
            }
            else
            {
                return myString.ToString();
            }
        }
    }
}
