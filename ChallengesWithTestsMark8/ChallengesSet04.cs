using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var num = 0;
            for(var x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 2 == 0)
                {
                    num += numbers[x];
                }
                else if (numbers[x] % 2 != 0)
                {
                    num -= numbers[x];
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
           
            List<string> strList = new List<string>();
            strList.Add(str1);
            strList.Add(str2);
            strList.Add(str3);
            strList.Add(str4); 

            int smallest = str1.Length;

            for(var x = 0; x < strList.Count; x++)
            {
                if (strList[x].Length < smallest)
                {
                    smallest = strList[x].Length;
                }
            }
            return smallest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> intList = new List<int>();
            intList.Add(number1);
            intList.Add(number2);
            intList.Add(number3);
            intList.Add(number4);

            int smallest = number1;

            for(var i = 0; i < intList.Count; i++)
            {
                if(intList[i] < smallest)
                {
                    smallest = intList[i];
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var triangle = false;

            if (sideLength1 + sideLength2 > sideLength3)
            {
               if (sideLength1 + sideLength3 > sideLength2)
               {
                   if (sideLength2 + sideLength3 > sideLength1)
                   {
                        triangle = true;
                   }
               }
            }
           
            return triangle;
        }

        public bool IsStringANumber(string input)
        {
             bool result = double.TryParse(input, out double _);
            return result;   
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            bool value = false;

           int nul = objs.Count(s => s == null);
           int not = objs.Count(s => s != null);
            if (nul > not)
            {
                value = true;
            }
            
            return value;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double evensCount = 0;
            double evensSum = 0;
            double evensAverage = 0;

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % 2 == 0)
                {
                    evensCount++;
                    evensSum += numbers[x];
                    evensAverage = evensSum / evensCount ;

                }
            }
            return evensAverage;
        }

        public int Factorial(int number)
        {
            int i;
            for (i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            if (number == 0)
            {
                number = 1;
            }
            

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}
