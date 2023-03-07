namespace DigitFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The Sum is: " + sumRange(0, 100000));
        }

        public static int sumRange(int start, int finish)
        {
            int sum = 0;
            for (int k = start; k <= finish; k++)
            {
                if (IsSpecialDigitFactorial(k))
                {
                    sum += k;
                    Console.WriteLine(k);
                }
            }

            return sum;
        }

        public static int Factorial(int input)
        {
            int[] factorialList = new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            if (input > 9)
            {
                if (input == 0) return 1;
                int sum = input;
                for (int i = (input - 1); i > 0; i--)
                {
                    sum *= i;
                }
                return sum;
            }

            return factorialList[input];
        }

        public static int DigitFactorial(int input)
        {
            string digits = input.ToString();
            int sum = 0;
            for(int i = 0; i < digits.Length; i++)
            {
                
                sum += Factorial(Int32.Parse(digits[i].ToString()));
                

            
            }
            return sum;


        }

        public static bool IsSpecialDigitFactorial(int input)
        {
            if (input <= 2) return false;
            return (input == DigitFactorial(input));
            
        }
    }
}