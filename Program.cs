using System;

namespace LuhnsAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validateCard("panumber"));
            Console.ReadLine();
        }
        static bool validateCard(string input)
        {
            // convert input to int
            int[] cardInt = new int[input.Length];

            for (int i =0; i<input.Length;i++)
            {
                cardInt[i] = (int)(input[i] - '0');
            }
            // starting from the right , double each oter digit , if greater than 9 mod 10 +1 to remainder
            for (int i = cardInt.Length - 2; i >= 0; i = i - 2)
            {
                int tempValue = cardInt[i];
                tempValue = tempValue * 2;
                if (tempValue > 9)
                {
                    tempValue = tempValue % 10 + 1;
                }
                cardInt[i] = tempValue;
            }
                // Add up all digits
                int total = 0;
                for(int i =0; i < cardInt.Length; i++)
                {
                    total += cardInt[i];
                }
            // if number is multiple of 10 it is valid
            if(total % 10==0)
            {
                return true;
            }
            return false;
        }

    }
}
