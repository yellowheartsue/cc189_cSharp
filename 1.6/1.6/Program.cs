using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._6
{
    class Program
    { //String compression, aabcccccaa to a2b1c5a2; if compressed one is longer, return the original one
        
        static void Main(string[] args)
        {
            String s1 = "abcdee";
            Console.WriteLine("Original: " + s1 + " , Compressed: " + stringCompression(s1));
        }

        //method 1: keep 2 pointers, use string builder, O(N) time, O(N) space
        static String stringCompression(String s) {
            int index = 0;
            int count = 1;
            StringBuilder sb = new StringBuilder();

            while ((index + count) <= s.Length) {

                if (index + count == s.Length) {
                    sb.Append(s[index]);
                    sb.Append(count);
                    break;
                }

                if (s[index + count] == s[index])
                    count++;
                else {
                    sb.Append(s[index]);
                    sb.Append(count);
                    index += count;
                    count = 1;
                }
            }

            if (sb.ToString().Length <= s.Length)
                return sb.ToString();

            return s;
        }

    }
}
