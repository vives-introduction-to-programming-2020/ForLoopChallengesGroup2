using System;

namespace ForLoopChallengesGroup2
{
    class Program
    {
        // 3, 6, 9, 12, ...
        // count = number of multiples
        // baseNumber = multiple of
        public static void Multiples(
            int count, int baseNumber)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i + 1) * baseNumber);
            }
        }

        // Counting uppercase characters in string
        public static int CountUpperCaseLetters
            (string text)
        {
            int upperCase = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter >= 'A' && letter <= 'Z')
                {
                    upperCase++;
                }
            }
            return upperCase;
        }

        public static int ConvertToNumber(string value)
        {
            int multiplier = 1;     // 1 (10^0), 10 (10^1), 100 (10^2) ...
            int sum = 0;
            for (int i = value.Length-1; i >= 0; i--)
            {
                char digit = value[i];
                int digitValue = (digit - '0') * multiplier;

                sum += digitValue;

                multiplier = multiplier * 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Multiples(10, 7);

            string text = "The Quick Brown Fox Jumps over the Lazy Dog";
            Console.WriteLine(
                $"{text} contains {CountUpperCaseLetters(text)} uppercase letters"
            );

            Console.WriteLine(ConvertToNumber("432343")+1);
        }
    }
}
