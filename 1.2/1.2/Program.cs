using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._2
{
    class Program //1.2 given 2 strings, see if one is permutation of the other
    {
        
        static void Main(string[] args)
        {
            String s1 = "appl es ";
            String s2true = "e sl pap";
            String s2false = "tigh ers";
            String s3 = "aaaaaaaaa";
            String s4 = "aaaaaaaaa";
            String s5 = "bbbbbbbbb";
            Console.WriteLine("true: " + isPermutation_withsort(s1, s2true));
            Console.WriteLine("false: " + isPermutation_withsort(s1, s2false));
            Console.WriteLine("true with hash table like: " + isPermutation_hashtableLike(s1, s2true));
            Console.WriteLine("false with hash table like: " + isPermutation_hashtableLike(s1, s2false));

            Console.WriteLine("true with brute force: " + isPermutation_bruteforce(s1, s2true));
            Console.WriteLine("false with brute force: " + isPermutation_bruteforce(s1, s2false));

            Console.WriteLine("true with brute force: " + isPermutation_bruteforce(s3, s4));
            Console.WriteLine("true with brute force: " + isPermutation_bruteforce(s3, s5));

        }

        //N is the length of one input String
        //method 1: sort 2 strings, compare, O(NlogN) time, O(1) space
        static bool isPermutation_withsort(String s1, String s2) {
            if (s1.Length != s2.Length)
                return false;

            s1 = sort(s1);
            s2 = sort(s2);

            for (int i = 0; i < s1.Length; i++) {
                if (s1[i] != s2[i])
                    return false;
            }
            return true;
        }
        static String sort(String s) {
            Array array = s.ToCharArray();
            Array.Sort(array);
            StringBuilder sb = new StringBuilder();
            foreach(char c in array){
                sb.Append(c);
            }
            return sb.ToString();
        }
        
        //method2: hashtable like, O(N) time, O(128) --> O(1) space, or with a map, which is O(N) space
        static bool isPermutation_hashtableLike(String s1, String s2) {
            if (s1.Length != s2.Length)
                return false;
            int[] checker = new int[128];

            for (int i = 0; i < s1.Length; i++) {
                char c = s1[i];
                checker[c]++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                char c = s2[i];
                checker[c]--;
                if (checker[c] < 0)
                    return false;
            }

            return true;
        }

        //method3: bruteforce, O(N^2) time, O(1) space
        static bool isPermutation_bruteforce(String s1, String s2) {
            if (s1.Length != s2.Length)
                return false;

            for(int i = 0; i < s1.Length; i++){
                for(int j = 0; j<s2.Length; j++){
                    if (s1[i] == s2[j])
                    {
                        s1 = s1.Remove(s1.IndexOf(s1[i]), 1);
                        s2 = s2.Remove(s2.IndexOf(s2[j]), 1);
                        i = -1;
                       
                        break;
                    }
                }
            }

            if (s1.Length == 0 && s2.Length == 0)
                return true;
            else return false;
           
        }
    }
}
