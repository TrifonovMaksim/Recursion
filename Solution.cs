using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Solutions
    {
        // 1 Задание.
        public double Pow(double N, int M)
        {
            if (M == 0) return 1;
            if (M < 0) return 1 / Pow(N, -M);
            return N * Pow(N, (M - 1));
        }

        // 2 Задание.
        public int SumOfDigits(int N)
        {
            if (N == 0) return 0;
            if (N < 0) N = -N;
            return N % 10 + SumOfDigits(N / 10); 
        }

        // 3 Задание.
        public int ListLength(List<int> N)
        {
            if (N.Count == 0) return 0;
            N.RemoveAt(0);
            return 1 + ListLength(N);
        }

        // 4 Задание.
        bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;
            return DoPalindromeCalc(word, left, right);
        }

        bool DoPalindromeCalc(string word, int left, int right)
        {
            if (left == right || left > right) return true;
            if (word[left] != word[right]) return false;
            return DoPalindromeCalc(word, left + 1, right - 1);
        }
    }
}
