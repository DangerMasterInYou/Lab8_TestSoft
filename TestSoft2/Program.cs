using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSoft2
{
    internal class Program
    {
        static int[] Sort(int[] mas)
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
        static bool Palindrom(string word)
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
        static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            if (n < 0) return -1;
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        static int Degree(int num, int deg)
        {
            int result = 1;
            for (; deg > 0; deg--)
            {
                result = result * num;
            }
            return result;
        }
        static bool PrimeNumber(int num)
        {
            for (int i = num - 1; i > 1; i--)
                if (num % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {

        }
    }
}
