using System;
using System.Collections;
using System.Diagnostics;

namespace CheckPermutation1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(checkPermutation("Holaa","alohaa"));
        }
        public static bool checkPermutation(string word1,string word2)
        {
            bool result = true;
            word1 = word1.ToUpper();
            word2 = word2.ToUpper();
            for (int x = 0; x < word1.Length;x++)
            {
                for (int y = 0; y < word2.Length;y++)
                {
                    if(word1[x]==word2[y])
                    {
                        word1 = word1.Remove(word1.IndexOf(word1[x]),1);
                        word2 = word2.Remove(word2.IndexOf(word2[x]),1);
                        result = true;
                        break;
                    }
                    else
                    {
                        result = false;
                    }
                }
                if(result)
                {
                    break;
                }

            }
          
            return result;
        }

        public static char[] SortString(string word)
        {
            
            word=word.ToUpper();
            char[] array = new char[word.Length];
            for (int x = 0; x < word.Length;x++)
            {
                array[x] = word[x];
            }
             Array.Sort(array);
            return array;
        }

    }
}
