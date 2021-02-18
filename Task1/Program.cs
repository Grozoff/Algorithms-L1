using System;

namespace Task1
{
    class Program
    {
        public class TestCase
        {
            public int Input { get; set; }
            public string Expected { get; set; }
        }
        static string JustNumb(int n)
        {
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }

            string actual;
            if (d == 0)
            {
                actual = "prime";
            }
            else
            {
                actual = "not a prime";
            }

            return actual;
        }
        static void Main(string[] args)
        {
            var testData = new TestCase[4];
            testData[0] = new TestCase()
            {
                Input = 2,
                Expected = "prime"
            };
            testData[1] = new TestCase()
            {
                Input = 57,
                Expected = "not a prime"
            };
            testData[2] = new TestCase()
            {
                Input = 181,
                Expected = "prime"
            };
            testData[3] = new TestCase()
            {
                Input = 132,
                Expected = "not a prime"
            };

            foreach (var testCase in testData)
            {
                var result = JustNumb(testCase.Input);
                var correct = result == testCase.Expected;
                Console.WriteLine($"Number: {testCase.Input} is {result}, Test: {correct}");
            }
        }
    }
}
