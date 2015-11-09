using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._4
{
    class Program
    { // given a String, check if it is a permutaion of palindrome
        static void Main(string[] args)
        {
            String s = "Tact Coa";
            String s1 = "abcaabac";
            String s2 = "abbb";
           // Console.WriteLine(isPermutationOfPalindrome("abbba")); //both s1 and s is true
            Console.WriteLine(isPermutationOfPalindrome2("abbccba")); //both s1 and s is true
        }

        //method 1: list all permutations, check each if it is a palindrome, O(n!) time, and I don't know how to list all permutations.

        //methid 2: use hash table like, O(n) time, O(128) space, n is s.length
        static bool isPermutationOfPalindrome(String s) {
            s = s.Replace(" ", "");
            s = s.ToLower();
            char[] array = s.ToCharArray();

            int[] checker = new int[128];
            foreach (char c in array){
                checker[c]++;
            }

            int counter = 0;
            for (int i = 0; i < checker.Length; i++)
            {
                if ((checker[i] % 2) == 1) {
                    if (counter == 1)
                        return false;

                    counter++;
                }
            }

            return true;
        }

        //Or assume only alphabetic character is allowed.
        static bool isPermutationOfPalindrome2(String s) {
            s = s.Replace(" ", "");

            int[] checker = new int[getNumericChar('z') - getNumericChar('a') + 1];
            int countOdd = 0;

            foreach (char c in s) {
                int x = getNumericChar(c);
                if (x != -1)
                    checker[x]++;

                if (checker[x] % 2 == 1)
                    countOdd ++;
                else
                    countOdd --;
            }

            return countOdd <= 1;
        }

        static int getNumericChar(char x) {
            int a = 'a';
            int z = 'z';
            int A = 'A';
            int Z = 'Z';
            int val = x;

            if (a <= val && val <= z) {
                return val - a;
            }
            else if (A <= val && val <= Z) {
                return val - A;
            }

            return -1;
        }

    }
}
