using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._7
{
    class Program
    {//1.7 rotate matrix

        static void Main(string[] args)
        {
        }

        //method : swap arrays layer by layer, counterclock, O(n^2) time
        static void rotate(int[][] metrix, int n){
            for (int layer = 0; layer < n / 2; ++layer) { 
                //length is n - layer;
                //swap 4 arrays;
                int first = layer;
                int last = (n - 1) - layer;
                for (int i = first; i < last; ++i)
                {
                    int offset = i - first;

                    //save top
                    int top = metrix[first][i];

                    //top <- right
                    metrix[first][i] = metrix[i][last];

                    //right <- bottom
                    metrix[i][last] = metrix[last][last - offset];

                    //bottom <- left
                    metrix[last][last - offset] = metrix[last - offset][first];

                    //left <- top
                    metrix[last - offset][first] = top;
                }
            }
        }
    }
}
