using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._9
{
    class Program
    {//Use one call of isSubString(stirngA, StringB) to determine if one string is another's rotation.

        static void Main(string[] args)
        {
            String[][] pairs = {new String[]{"apple", "pleap"},
                               new String[]{"waterbottle", "erbottlewat"},
                               new String[]{"camera", "macera"}};
            foreach (String[] pair in pairs) {
                String s1 = pair[0];
                String s2 = pair[1];

                Console.WriteLine("s1 is {0} and s2 is {1}, isRotation result: {2}", s1, s2, isRotation(s1, s2));
            }
            
        }

        //method, run time based on isSubString
        static bool isRotation(String s1, String s2)
        {
            int l = s1.Length;
            if (s2.Length == l && l > 0) {
                String s1s1 = s1 + s1;
                return isSubstring(s1s1, s2);
            }
            return false;

        }

        //Given method String
        static bool isSubstring(String big, String small)
        {
            if (big.IndexOf(small) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
