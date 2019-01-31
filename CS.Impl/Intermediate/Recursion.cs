using System;
using System.Collections.Generic;

namespace CS.Impl
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            var liste = new List<int> { };
            int i = 1;
            while (i <= n)
            {
                liste.Add(i);
                i++;
            }
            return liste;

        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {

            throw new NotImplementedException();
        }

        public int SumNaturalNumbers(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; ++i)
            {
                sum += i;
            }

            return sum;
        }

        private int ComputeSum(int min, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            else
            {
                for (int a = 2; a <= n / 2; a++)
                {
                    if (n % a == 0)
                    {
                        return false;
                    }

                }
                return true;
            }

        }

        private bool IsPrime(int n, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPalindrome(string text)
        {
            string first = text.Substring(0, text.Length / 2);
            char[] arr = text.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);

        }
    }
}
