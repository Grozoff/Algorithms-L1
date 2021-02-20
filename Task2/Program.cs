using System;

namespace Task2
{
    class Program
    {
        /* 
         * Общая производительность алгоритма O(N^3)
         * Связано это с тем что каждый вложенный цикл повторно пересматривает все N элементы массива,
         * совершая те же O(N) шагов
         */

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) 
            {
                for (int j = 0; j < inputArray.Length; j++) 
                {
                    for (int k = 0; k < inputArray.Length; k++) 
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3 }; 
            StrangeSum(Array);          // Передал массив что бы наглядно посчитать сложность алгоритма
        }
    }
}
