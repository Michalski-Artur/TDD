using System;

namespace TDD
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if(numbers == String.Empty)
                return 0;

            int result = 0;
            string[] separatedNumbers = numbers.Split(',', '\n');
            for(int i=0;i<separatedNumbers.Length;i++)
            {
                int number = int.Parse(separatedNumbers[i]);
                if (number < 0)
                    throw new ArgumentException("Negative number");
                if (number > 1000)
                    continue;
                result += number;
            }
            return result;
        }

    }
}
