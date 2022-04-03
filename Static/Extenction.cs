using System;
using System.Collections.Generic;
using System.Text;

namespace Static
{
    public static class Extenction
    {
        public static bool IsOdd(this int num)
        {
            if(num%2 != 0)
            {
                return true;
            }
            return false;
                
        }
        public static bool IsEven(this int num)
        {
            if(num%2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this  string smth)
        {
            foreach(var item in smth)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCaptalize(this string smth)
        {
            string newsmth = "";
            if (char.IsUpper(smth[0]))
            {
                return smth;
            }
            newsmth = newsmth + char.ToUpper(smth[0]);
            for(int i = 0; i < smth.Length; i++)
            {
                newsmth = newsmth + smth[i];
            }
            return newsmth;

                  
        }
        public static int[] GetValueIndexes(this string smth, char ch)
        {
            int[] arr = new int[0];
            for(int i = 0; i < smth.Length; i++)
            {
                if(smth[i] == ch)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }return arr;
        }
    }
}
