using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._5
{
    class Program
    { //1.5, One away. There are 3 types of edits that can be proformed on String, insert, remove or replace a character. 
      //Given 2 strings, check if they are one edit or zero edits away.

        static void Main(string[] args)
        {
            string s1 = "pale";
            string s2 = "pales";
            String s3 = "abd";
            String s4 = "ade";
            //Console.WriteLine(ifOneEdit_hashTableLike(s1, s2));
            //Console.WriteLine(ifOneEdit_withSort(s3, s4));
            //Console.WriteLine(oneEditAway(s1, s2));
            Console.WriteLine(oneEditAwayCompact(s3, s4));
        }


        //method1 from book: O(n) time, n is the length of the shorter one
        static bool oneEditAway(String s1, String s2) {
            if (s1.Length == s2.Length)
                return oneEditAwayReplace(s1, s2);
            if (s1.Length + 1 == s2.Length)
                return oneEditAwayInsertRemove(s1, s2);
            if (s1.Length - 1 == s2.Length)
                return oneEditAwayInsertRemove(s2, s1);

            return false;
        }

        private static bool oneEditAwayInsertRemove(string s1, string s2)
        {
            int index1 = 0;
            int index2 = 0;
            while (index1 < s1.Length && index2 < s2.Length) {
                if (s1[index1] != s2[index2])
                {
                    if (index1 != index2)
                        return false;
                }
                else
                    index1++;
                index2++;
            }
            return true;
        }

        static bool oneEditAwayReplace(string s1, string s2)
        {
            bool findDifferency = false;
            for (int i = 0; i < s1.Length; i++) {
                if (s1[i] != s2[i]) {
                    if (findDifferency)
                        return false;
                    findDifferency = true;
                }     
            }
            return true;
        }

        //method 2 from book, O(n) time, n is the length of the shorter one
        static bool oneEditAwayCompact(String first, String second) {
            if (Math.Abs(first.Length - second.Length) > 1)
                return false;

            String s1 = (first.Length < second.Length) ? first : second;
            String s2 = (first.Length < second.Length) ? second : first;

            int index1 = 0;
            int index2 = 0;
            bool findDifferency = false;

            while (index1 < 0 && index2 < 0) {
                if (s1[index1] != s2[index2])
                {
                    if (findDifferency)
                        return false;
                    findDifferency = true;

                    if (s1.Length == s2.Length)
                        index1++;
                }
                else
                    index1++;

                index2++;
            }
            return true;
        }


        //method 1: hash table like, O(n) time, O(128*2) -> O(1) space
        static bool ifOneEdit_hashTableLike(String s1, String s2)
        {
            if (Math.Abs(s1.Length - s2.Length) > 1)
                return false;
            
            //patch to shorter one
            if (s1.Length < s2.Length)
                s1 = s1 + ' ';
            else if (s2.Length < s1.Length)
                s2 = s2 + ' ';

            //to checker table
            int[] checker1 = toTable(s1);
            int[] checker2 = toTable(s2);

            //check 2 tables
            int skipped = 0;
            for (int i = 0; i < checker1.Length; i++) {
                if (checker1[i] != checker2[i]) {
                    if (skipped > 1)
                        return false;
                    skipped++;
                }
            }

                return true;
        }

        static int[] toTable(String s) {
            s = s.ToLower();
            int[] checker = new int[128];

            foreach (char c in s)
                checker[c]++;
            
            return checker;
            
        }

        //method 2: sort, O(nlogn) time, O(1) space.
        static bool ifOneEdit_withSort(String s1, String s2) {
            if (Math.Abs(s1.Length - s2.Length) > 1)
                return false;

            //patch to shorter one
            if (s1.Length < s2.Length)
                s1 = s1 + ' ';
            else if (s2.Length < s1.Length)
                s2 = s2 + ' ';

            //sort s1 and s2
            s1 = sortString(s1);
            s2 = sortString(s2);

            //check
            int s1skip = 0;
            int s2skip = 0;
            int j = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[j]) {
                    if (s1skip > 1 && s2skip >1){
                        return false;
                    }
                    else {
                        if (i + 1 < s1.Length && j + 1 < s2.Length)
                        {
                            if (s1[i + 1] == s2[j + 1])
                            {
                                s1skip++;
                                s2skip++;
                                i++;
                                j++;
                            }
                            else if (s1[i] == s2[j + 1])
                            {
                                s2skip++;
                                j++;
                            }
                            else if (s1[i + 1] == s2[j])
                            {
                                s1skip++;
                                i++;
                            }
                            else
                            {
                                return false;
                            }
                        }

                        // i+1 = s1. length or j+1 = s2.length or both of i+1 = j+1 = s1.length
                        else {
                            if(!(s1skip == 0 && s2skip == 0))
                                return false;
                        }
                    }
                }

                if (j == s2.Length - 1)
                    break;
                j++;
               
            }
            return true;
        }

        static string sortString(String s) {
            char[] array = s.ToCharArray();
            Array.Sort(array);
            s = new String(array);
            return s;
        }

    }
}
