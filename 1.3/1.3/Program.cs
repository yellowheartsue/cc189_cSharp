using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._3
{
    class Program //url verify: replace all " " in a String with "%20"
    {
        static void Main(string[] args)
        {
            String s1 = "a b c d";
            Console.WriteLine(replace_withSplitandAppend(s1) + "FF");

            String s2 = "a b c d      ";
            Console.WriteLine(replace_withBackwardCopy(s2, 7) + "FF");
        }

        //method 1: use split and append, O(# of space)time, O(1) space
        static String replace_withSplitandAppend(String s)
        {
            String[] subs = s.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < subs.Length; i++) {
                if (i == (subs.Length - 1)) sb.Append(subs[i]);
                else sb.Append(subs[i] + "%20");
            }
            return sb.ToString();
        }

        //method 2: backward copy, O(N) time, O(1) space
        static String replace_withBackwardCopy(String s, int truelength)
        {
            char[] a = s.ToCharArray();
            int lastspace = a.Length - 1;
            int offset = a.Length - truelength;
            for (int i = truelength - 1; i > 0; i--) {
                if (!a[i].Equals(' '))
                { //copy char to last index which has a ' ' on.
                    a[lastspace] = a[i];
                   // a[i] = ' ';  //no need to make it to ' '
                    lastspace--;
                }
                else {
                    a[i + offset] = '0';  //a[lastspace -1] = '0'; i + offset = lastspace - 1;
                    a[i - 1 + offset] = '2'; //a[lastspace -2] = '2';
                    a[i - 2 + offset] = '%'; //a[lastspace -3] = '3';
                    offset -= 2;            //lastspace -= 3;
                    lastspace -= 3;
                }
            }

            return new String(a);
        }
    }
}
