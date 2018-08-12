using System;

namespace ZeroMatrix1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] arreglo = new int[4, 4] {{1,2,3,4},{ 1, 2, 0, 4 } ,{ 1, 2, 3, 4 } ,{ 1, 2, 3, 4 }  };
          

            for (int x = 0; x < Math.Sqrt(arreglo.Length); x++)
            {
                for (int y = 0; y < Math.Sqrt(arreglo.Length); y++)
                {
                    Console.Write(arreglo[x, y]);
                }
                Console.WriteLine("\n");
            }

            ZeroMatrix(arreglo);

            Console.WriteLine("-----------------------\n");

            for (int x = 0; x < Math.Sqrt(arreglo.Length); x++)
            {
                for (int y = 0; y < Math.Sqrt(arreglo.Length); y++)
                {
                    Console.Write(arreglo[x, y]);
                }
                Console.WriteLine("\n");
            }
        }

        public static void ZeroMatrix(int[,] array)
        {
            int[,] array2 = new int[(int)Math.Sqrt(array.Length),(int)Math.Sqrt(array.Length)];
            Array.Copy(array, array2, array.Length);
         

            for (int x = 0; x < Math.Sqrt(array.Length); x++)
            {
                for (int y = 0; y < Math.Sqrt(array.Length); y++)
                {
                    if (array[x, y] == 0)
                    {
                        ChangeValues(array2, x, y);
                        Console.WriteLine(x + "," + y);
                       
                     
                    }

                }
            }


            Array.Copy(array2, array,array2.Length);
            
        }
        public static void ChangeValues(int[,] array2,int row, int column)
        {
            for (int x = 0; x < Math.Sqrt(array2.Length); x++)
            {
                array2[row, x] = 0;
                array2[x, column] = 0;
                
            }
        }
    }
}
