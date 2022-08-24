using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindromIndex
{
    public class IsPalindromIdx
    {
        public static int palindromeIndex(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end && s.ToCharArray(start, 1) == s.ToCharArray(end, 0))
            {
                start++;
                end--;
            }
            if (start >= end) return -1;
            if (isPalindrome(s, start + 1, end)) return start;
            if (isPalindrome(s, start, end - 1)) return end;
            return -1;
        }

        public static bool isPalindrome(String s, int start, int end)
        {
            while (start < end && s.ToCharArray(start, end) == s.ToCharArray(end, start))
            {
                start++;
                end--;
            }
            return start >= end;
        }
    }
}
