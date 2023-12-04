using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoft2
{
    public class Function
    {
        public int[] Sort(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                (mas[min], mas[i]) = (mas[i], mas[min]);
            }
            return mas;
        }
        public bool Palindrom(string word)
        {
            var left = 0;
            var right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right]) return false;
                left++;
                right--;
            }
            return true;
        }
        public int Factorial(int n)
        {
            if (n < 1) throw new ArgumentOutOfRangeException("Out Range");
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        public int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            if (n < 0) return -1;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        public int Degree(int num, int deg)
        {
            if (deg < 0) return deg;
            if (deg == 0) return 1;
            int result = 1;
            for (; deg > 0; deg--)
            {
                result = result * num;
            }
            return result;
        }
        public bool PrimeNumber(int num)
        {
            for (int i = num - 1; i > 2; i--)
            {
                if (num % i == 0)
                    return true;
            }

            return true;
        }
    }
}
