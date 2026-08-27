using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        void PrintEvenValues(List<int> lst)
        {
            int i = 0;
            DoPrintEvenValues(lst, i);
        }

        void DoPrintEvenValues(List<int> lst, int i)
        {
            if (i == lst.Count) return;
            if (lst[i] % 2 == 0) System.Console.WriteLine(lst[i]);
            DoPrintEvenValues(lst, i + 1);
        }

        // 6 Задание.
        void PrintEvenIdx(List<int> lst)
        {
            int i = 0;
            DoPrintEvenIdx(lst, i);
        }

        void DoPrintEvenIdx(List<int> lst, int i)
        {
            if (i >= lst.Count) return;
            System.Console.WriteLine(lst[i]);
            DoPrintEvenIdx(lst, i + 2);
        }

        // 7  Задание.
        T FindSecondMaxValue<T>(List<T> lst) where T : IComparable<T>
        {
            T FirstMax, SecondMax;
            if (lst.Count < 2) return default(T);
            if (lst[0].CompareTo(lst[1]) >= 0)
            {
                FirstMax = lst[0];
                SecondMax = lst[1];
            }
            else
            {
                FirstMax = lst[1];
                SecondMax = lst[0];
            }
            int i = 2;
            return DoFindSecondMaxValue(lst, FirstMax, SecondMax, i);
        }

        T DoFindSecondMaxValue<T>(List<T> lst, T FirstMax, T SecondMax, int i) where T : IComparable<T>
        {
            if (i == lst.Count) return SecondMax;
            if (lst[i].CompareTo(FirstMax) >= 0) return DoFindSecondMaxValue(lst, lst[i], FirstMax, i + 1);
            if (lst[i].CompareTo(SecondMax) >= 0) return DoFindSecondMaxValue(lst, FirstMax, lst[i], i + 1);
            else return DoFindSecondMaxValue(lst, FirstMax, SecondMax, i + 1);
        }

        // 8 Задание.
        List<string> FindAllFiles(string path)
        {
            List<string> result = new List<string>();
            DoFindAllFiles(path, result);
            return result;
        }

        void DoFindAllFiles(string path, List<string> result)
        {
            result.AddRange(Directory.GetFiles(path));
            foreach (string Path in Directory.GetDirectories(path))
            {
                DoFindAllFiles(Path, result);
            }
        }

    }
}
