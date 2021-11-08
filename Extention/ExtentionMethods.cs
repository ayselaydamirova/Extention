using System;
using System.Collections.Generic;
using System.Text;

namespace Extention
{
    static class ExtentionMethods
    {
        public static bool IsOdd(this int num1)
        {
            if (num1 % 2 != 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(this int num2)
        {
            if (num2 % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string text1)
        {
            for (int i = 0; i < text1.Length; i++)
            {
                if (char.IsDigit(text1[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string text2)
        {
            return char.ToUpper(text2[0]) + text2.Substring(1).ToLower();
        }
        public static int[] GetValueIndexes(this string text3, char digit)
        {
            int count = 0;
            for (int i = 0; i < text3.Length; i++)
            {
                if (text3[i] == digit)
                {
                    count++;
                }
            }

            int[] arrayint = new int[count];
            int index = 0;
            for (int i = 0; i < text3.Length; i++)
            {
                if (text3[i] == digit)
                {
                    arrayint[index] = i;
                    index++;
                }
            }
            return arrayint;
        }
    }
}
}
