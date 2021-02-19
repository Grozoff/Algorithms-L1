using System;

namespace Task3_recursion
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

            if (number == 0 || number == 1)
            {
                return number;
            }
            return GetFibonachi(number - 1) + GetFibonachi(number - 2);

            //return number <=1 ? number : GetFibonachi(number - 1) + GetFibonachi(number - 2); // С помощью тернарного оператора
        }
        static void Main(string[] args)
        {
            var testData = new TestCase[3];
            testData[0] = new TestCase()
            {
                Input = 7,
                Expected = "0 1 1 2 3 5 8"
            };
            testData[1] = new TestCase()
            {
                Input = 9,
                Expected = "0 1 1 2 3 5 8 13 21"
            };
            testData[2] = new TestCase()
            {
                Input = 11,
                Expected = "0 1 1 2 3 5 8 13 21 34 55"
            };

            // Input - количество элементов строки фибоначи

            foreach (var testCase in testData)
            {
                Console.Write("Фактическое значение: ");
                var result = testCase.Input;
                var test = testCase.Expected;
                for (int i = 0; i < result; i++)
                {
                    var comp = i + 1 == result ? string.Empty : "";
                    Console.Write($"{GetFibonachi(i)}{comp} ");
                }
                Console.WriteLine($"\nОжидаемое значение : {test}\n");
            }
            Console.ReadLine();
        }
    }
}
