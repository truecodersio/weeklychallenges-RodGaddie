using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           
            if ( numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else 
            {
                double sum = numbers.Max() + numbers.Min();
                return sum;
            }
           
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
                return sum;
              
               
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                    
            }
                     return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return false;
            }

            for (var i = 0; i < numbers.Count(); i++)
            {
                sum += numbers[i];
            }
                if (sum % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            for (long i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            if (number < 0)
            {
                return 0;
            }
            return count;
        }
    }
}
