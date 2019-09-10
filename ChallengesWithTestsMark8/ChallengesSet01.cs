using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
          if ( num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double m = minuend;
            double s = subtrahend;
                return m - s;
        }

        public int Add(int number1, int number2)
        {
            int num1 = number1;
            int num2 = number2;
            return num1 + num2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if( number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            throw new NotImplementedException();
        }

        public string GetHey()
        {
            throw new NotImplementedException();
        }
    }
}
