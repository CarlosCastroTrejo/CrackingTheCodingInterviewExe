using System;
using System.Diagnostics;

namespace Exercise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(CheckUnique("abcdaefghijklm"));
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        public static bool CheckUnique(string word)
        {
            for (int x = 0; x < word.Length;x++)
            {
                for (int y = 0; y < word.Length; y++)
                {
                    if (x!=y)
                    {
                        if(word[x]==word[y])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        } 
    }
}
