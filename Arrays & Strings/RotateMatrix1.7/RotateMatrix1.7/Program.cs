using System;

namespace RotateMatrix1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = 1;
            int[,] array = new int[4,4];
            for (int x = 0; x < 4;x++)
            {
                for (int y= 0; y < 4; y++)
                {
                    array[x,y] = number;
                    number++;
                }
               
            }
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(array[x, y]+" ");
                }
                Console.WriteLine("\n");


            }
        }
        public static void RotateMatrix()
        {
            
        }
    }
}

/*
 1 2 3 4
 5 6 7 8
 9 10 11 12
 13 14 15 16

13 9 5 1
14 10 6 2
15 11 7 3
16 12 8 4  





 */