using System;

namespace Task3
{
    class Program
    {
        public class TestCase
        {
            public int Input { get; set; }
            public string Expected { get; set; }
        }

        static int GetFibonachi(int number)
        {
            int a = 0;
            int b = 1;
            int tmp;
            Console.Write("Фактическое значение: ");
            for (int i = 0; i < number; i++)
            {
                tmp = a;
                a = b;
                Console.Write($"{tmp} ");
                b += tmp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            var testData = new TestCase[3];
            testData[0] = new TestCase()
            {
                Input = 6,
                Expected = "0 1 1 2 3 5"
            };
            testData[1] = new TestCase()
            {
                Input = 8,
                Expected = "0 1 1 2 3 5 8 13"
            };
            testData[2] = new TestCase()
            {
                Input = 10,
                Expected = "0 1 1 2 3 5 8 13 21 34"
            };

            /// Input - количество элементов строки фибоначи

            foreach (var testCase in testData)
            {
                GetFibonachi(testCase.Input);
                var test = testCase.Expected;
                Console.WriteLine($"\nОжидаемое значение : {test}\n");
            }

        }
    }
}
