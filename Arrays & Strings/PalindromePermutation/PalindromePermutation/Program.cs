using System;
using System.Diagnostics;

namespace PalindromePermutation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(PPErmutatuon("anita lava la tina"));
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

        }
        public static bool PPErmutatuon(string word)
        {
            bool palindrome = true;
            int PermutationCounter = 0,SingleCounter=0;

            char character = '\n';
            while(word.Contains(" "))
            {
                
                word = word.Remove(word.IndexOf(" "),1);

            }
          
            char[] array = StringToArray(word);
            Array.Sort(array);
            for (int x = 0; x < array.Length;x++)
            {
                Console.WriteLine(array[x]);
            }

            for (int x = 0; x < array.Length-1;x++)
            {
                character = array[x];
                if (character == array[x + 1])
                {
                    PermutationCounter++;
                }
                else if(character != array[x + 1] && PermutationCounter>=1)
                {
                    PermutationCounter=0;
                }
                else if (character != array[x + 1] )
                {
                    SingleCounter++;
                }


                if(SingleCounter==2)
                {
                    palindrome = false;
                    break;
                }
                
            }


            return palindrome;
        }
        public static char[] StringToArray(string word)
        {
            char[] array = new char[word.Length];
            word = word.ToUpper();
            for (int x = 0; x < word.Length;x++)
            {
                array[x] = word[x];
            }
            return array;
        }
    }
}
