using System;

namespace StringRotation1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(StringRotation("waterbottle", "erbottlewat"));
        }

        public static bool Substring(string word1,string word2)
        {
            if(word1.Contains(word2))
            {
                return true;
            }else
            {
                return false;
            }
            
        }
        public static bool StringRotation(string word1,string word2)
        {
            if(Substring(word1,word2))
            {
                return false;
            }else
            {
                
                return true;
            }
            
        }
    }
}
