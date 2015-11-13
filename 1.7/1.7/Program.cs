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
            int n = 6;
            int[][] metrix = randomMatrix(n, n, 1, 50);
            printMatrix(metrix);
            Console.WriteLine("rotating...");
            rotate(metrix, n);
            printMatrix(metrix);

        }

        //method : swap arrays layer by layer, counterclock, O(n^2) time
        static void rotate(int[][] metrix, int n)
        {
            for (int layer = 0; layer < n / 2; ++layer)
            {
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

        public static int[][] randomMatrix(int M, int N, int min, int max) {
		    int[][] matrix = new int[M][];
            Random random = new Random();

            for (int i = 0; i < M; i++) {
                matrix[i] = new int[N];
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i][j] = random.Next(min, max);
                }
            }
		    return matrix;
	    }

        public static void printMatrix(int[][] matrix) {
		    for (int i = 0; i < matrix.Length; i++) {
			    for (int j = 0; j < matrix[i].Length; j++) {
				    if (matrix[i][j] < 10 && matrix[i][j] > -10) {
					    Console.Write(" ");
				    }
				    if (matrix[i][j] < 100 && matrix[i][j] > -100) {
					    Console.Write(" ");
				    }
				    if (matrix[i][j] >= 0) {
					    Console.Write(" ");
				    }
				    Console.Write(" " + matrix[i][j]);
			    }
                Console.WriteLine();
		    }
	    }
    }
}
