using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Rectangular arrays
            int[,] matrix = new int[3, 3];

            Console.WriteLine(matrix.Length);

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            //Console.WriteLine(matrix.GetLength(2));  out of index exception

            Console.ReadLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j + 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.WriteLine(matrix[i,j]);

            var rectMatrix = new int[,] // rectMatrix is implicitly of type int[,]
                            {
                                {0,1,2},
                                {3,4,5},
                                {6,7,8}
                            };

            for (int i = 0; i < rectMatrix.GetLength(0); i++)
                for (int j = 0; j < rectMatrix.GetLength(1); j++)
                    Console.WriteLine(rectMatrix[i, j]);
            
            Console.ReadLine();
            #endregion

            #region Jagged arrays         each element is an array
            int[][] matrix2 = new int[3][]
            {
                new int[] {1},
                new int[] {2, 3},
                new int[] {4, 5, 6}
            };

            for (int i = 0; i < matrix2.GetLength(0); i++)
                for (int j = 0; j < matrix2[i].GetLength(0); j++)
                    Console.WriteLine(matrix2[i][j]);
            Console.ReadLine();
            #endregion

            #region params parameters

            int total = Sum(1, 2, 3, 4);
            int total2 = Sum(new int[] { 1, 2, 3, 4 });

            int Sum(params int[] ints)
            {
                int sum = 0;
                for (int i = 0; i < ints.Length; i++)
                    sum += ints[i]; // Increase sum by ints[i]
                return sum;
            }
            Console.WriteLine(total);
            Console.WriteLine(total2);

            Console.ReadLine();


            double dTotal = Sum2(15, 1, 2, 3, 4);
            double dTotal2 = Sum2(15.0, new int[] { 1, 2, 3, 4 });

            double Sum2(double y, params int[] ints)
            {
                int sum = 0;
                for (int i = 0; i < ints.Length; i++)
                    sum += ints[i]; // Increase sum by ints[i]
                return sum + y;
            }

            Console.WriteLine(dTotal);
            Console.WriteLine(dTotal2);
            Console.ReadLine();

            #endregion

            #region Ref Locals
            int[] numbers = { 0, 1, 2, 3, 4 };
            ref int numRef = ref numbers[2];

            numRef *= 10;
            Console.WriteLine(numRef); // 20
            Console.WriteLine(numbers[2]); // 20
            Console.ReadLine();
            #endregion
        }
    }
}
