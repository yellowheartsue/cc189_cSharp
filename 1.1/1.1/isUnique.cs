using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._1
{
    class isUnique
    {
        static void Main(string[] args)
        {
            String unique = "tigers";
            String notUnique = "apples";
            //Console.WriteLine("Unique: " + isUnique_bruteforce(unique) + " notUnique: " + isUnique_bruteforce(notUnique));
            //Console.WriteLine("Unique: " + isUnique_hashtablelike(unique) + " notUnique: " + isUnique_hashtablelike(notUnique));
            //Console.WriteLine("Unique: " + isUnique_withSet(unique) + " notUnique: " + isUnique_withSet(notUnique));
            Console.WriteLine("Unique: " + isUnique_withSort(unique) + " notUnique: " + isUnique_withSort(notUnique));

        }

        //method 1: brute force, O(n^2) time, O(1) space 
        static bool isUnique_bruteforce(String s) {
            if (s.Length > 128)
                return false;

            for (int i = 0; i < s.Length; i++) {
                for (int j = 0; j < s.Length; j++) {
                    if (i == j)
                        continue;
                    else {
                        if (s[i] == s[j]) {
                            return false;
                        }
                    }
                }
            
            }
                return true;
        }

        //method 2: hash table like function, O(n) time, O(1) space
        static bool isUnique_hashtablelike(String s)
        {
            if (s.Length > 128)
                return false;

            bool[] checker = new bool[128];
            for (int i = 0; i < s.Length; i++) {
                if (checker[s[i]])
                    return false;
                else
                    checker[s[i]] = true;
            }
            return true;
        }

        //method 3: use a set
        static bool isUnique_withSet(String s)
        {
            if (s.Length > 128) return false;
            HashSet<Char> set = new HashSet<Char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!set.Add(s[i]))
                {
                    return false;
                }
            }
            return true;
        }

        //method 4: sort string first, then check 2 neighbour chars if same
        static bool isUnique_withSort(String s)
        {

            if (s.Length > 128) return false;
            Array charArray = s.ToArray<Char>();
            Array.Sort(charArray);
            StringBuilder sb = new StringBuilder();
            foreach (Char c in charArray) {
                sb.Append(c);
            }
            s = sb.ToString();

            for (int i = 0; i < (s.Length-1); i++) {
                if (s[i] == s[i + 1])
                    return false;
            }

            return true;
        }
    }
}
