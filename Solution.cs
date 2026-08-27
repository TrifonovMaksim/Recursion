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

        // 5 Задание.
        void PrintEvenValues(List<int> lst, int i = 0)
        {
            if (i == lst.Count) return;
            if (lst[i] % 2 == 0) System.Console.WriteLine(lst[i]);
            PrintEvenValues(lst, i + 1);
        }

        // 6 Задание.
        void PrintEvenIdx(List<int> lst, int i = 0)
        {
            if (i >= lst.Count) return;
            System.Console.WriteLine(lst[i]);
            PrintEvenIdx(lst, i + 2);
        }

        // 7  Задание.
        int FindSecondMaxValue(List<int> lst)
        {
            if (lst.Count < 2) return -1;
            int FirstMax = lst[0];
            int SecondMax = int.MinValue;
            return DoFindSecondMaxValue(lst, FirstMax, SecondMax);

        }

        int DoFindSecondMaxValue(List<int> lst, int FirstMax, int SecondMax, int i = 1)
        {
            if (i == lst.Count) return SecondMax;
            if (lst[i] >= FirstMax) return DoFindSecondMaxValue(lst, lst[i], FirstMax, i + 1);
            if (lst[i] >= SecondMax) return DoFindSecondMaxValue(lst, FirstMax, lst[i], i + 1);
            else return DoFindSecondMaxValue(lst, FirstMax, SecondMax, i + 1);
        }

    }
}
