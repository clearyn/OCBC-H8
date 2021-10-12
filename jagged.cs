using System;

    class Jagged
    {
        static void Main()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];
            int i;
            
            //Array [0][indeks]
            for (i = 0; i < 4; i++)
            {
                jagged[0][i] = i;
            }

            //Array [1][indeks]
            for (i = 0; i < 3; i++)
            {
                jagged[1][i] = i;
            }

            //Array [2][indeks]
            for (i = 0; i < 5; i++)
            {
                jagged[2][i] = i;
            }

            //Show Array [0][indeks]
            for (i = 0; i < 4; i++)
            {
                Console.Write(jagged[0][i] + " ");
            }
            Console.WriteLine();

            //Show Array [1][indeks]
            for (i = 0; i < 3; i++)
            {
                Console.Write(jagged[1][i] + " ");
            }
            Console.WriteLine();

            //Show Array [2][indeks]
            for (i = 0; i < 5; i++)
            {
                Console.Write(jagged[2][i] + " ");
            }
            Console.WriteLine();

        }
    }