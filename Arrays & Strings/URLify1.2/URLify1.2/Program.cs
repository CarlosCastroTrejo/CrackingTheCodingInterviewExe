using System;
using System.Collections;
using System.Text;

namespace URLify1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(URlify("Mr. Jhon Smith "));
        }
        public static string URlify(string word)
        {
            bool spaces = true;
            while(spaces)
            {
                word = word.Insert(word.IndexOf(" "),"%20");
                word = word.Remove(word.IndexOf(" "), 1);
                if(!word.Contains(" "))
                {
                    spaces = false; 
                }
            }


            return word;
        }
    }
}
