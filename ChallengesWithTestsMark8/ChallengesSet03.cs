using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false; 
            }
            bool contains = false;
            for (var i = 0; i < vals.Length; i++)
            {
               if (vals[i] == false)
               { 
                    contains = true;
               }
            }
               return contains;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            bool odd = false;
            var sum = 0;
            foreach (int value in numbers)
            {
                sum += value;
            }
            if (sum % 2 != 0)
            {
                odd = true;
            }
           
            return odd;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
            bool isUp = false;
            bool isLow = false;
            bool isNum = false;
            bool goodTG = false;

            for (var i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    isUp = true;
                }
                if (char.IsLower(password[i]))
                {
                    isLow = true;
                }
                if (char.IsDigit(password[i]))
                {
                    isNum = true;
                }
            }
            if (isUp && isLow && isNum)
            {
                goodTG = true;
            }
            return goodTG;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var last = val[val.Length -1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            var answer = dividend / divisor;
            return answer;
        }

        public int LastMinusFirst(int[] nums)
        {
            int answer = nums[nums.Length - 1] - nums[0];
            return answer;
        }

        public int[] GetOddsBelow100()
        {
            var myList = new List<int>();
            for (var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    myList.Add(i);
                }
            }
            return myList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper(); 
            }
        }
    }
}
