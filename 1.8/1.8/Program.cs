using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._8
{
    class Program
    {//zero metrix: Write an algorithm such that if an element in an M*N matrix is 0, its entire row and column are set to 0.

        static void Main(string[] args)
        {
            int M = 5;
            int N = 6;
            int[][] metrix = randomMatrix(M, N, -10, 10);
            int[][] metrix2 = cloneMatrix(metrix, N);
            printMatrix(metrix);

            Console.WriteLine("cleaning...");
            setZerosofMetrix(metrix);
            printMatrix(metrix);

            Console.WriteLine("2nd method: ");
            setZeroOfMetrix2(metrix2);
            printMatrix(metrix2);

            Console.ReadLine();

        }
        //Method 1:go through, using sets or bool[] to save i, j values, go through bool[], set i/j row/column to 0.
        //O(m*n) time, O(m+n) space
        static void setZerosofMetrix(int[][] metrix) {
            bool[] row = new bool[metrix.Length];
            bool[] col = new bool[metrix[0].Length];

            for(int i = 0; i <metrix.Length; i++) {
                for (int j = 0; j < metrix[0].Length; j++) {
                    if (metrix[i][j] == 0) {
                        row[i] = true;
                        col[j] = true;
                    }
                }
            }

            for(int k = 0; k < row.Length; k++){
                if (row[k])
                    setRowToZero(metrix, k);
            }

            for (int k = 0; k < col.Length; k++) {
                if (col[k])
                    setColToZero(metrix, k);
            }
        }

        static void setColToZero(int[][] metrix, int col) {
            for (int i = 0; i < metrix.Length; i++) {
                metrix[i][col] = 0;
            }
        }

        static void setRowToZero(int[][] metrix, int row) {
            for (int j = 0; j < metrix[0].Length; j++) {
                metrix[row][j] = 0;
            }
        }

        //Method 2: almost like method 1, but save info into metrix itself. O(m*n) time, O(1) space
        static void setZeroOfMetrix2(int[][] metrix) {
            bool rowHasZero = false;
            bool colHasZero = false;

            for (int i = 0; i < metrix.Length; i++) { 
                if(metrix[i][0] == 0){
                    colHasZero = true;
                    break;
                }
            }

            for (int j = 0; j < metrix[0].Length; j++) {
                if (metrix[0][j] == 0) {
                    rowHasZero = true;
                    break;
                }
            }

            for (int i = 1; i < metrix.Length; i++){
                for (int j = 1; j < metrix[0].Length; j++) {
                    if (metrix[i][j] == 0){
                        metrix[0][j] = 0;
                        metrix[i][0] = 0;
                    }
                }
            }

            for (int i = 1; i < metrix.Length; i++) {
                if (metrix[i][0] == 0) {
                    setRowToZero(metrix, i); 
                }
            }

            for (int j = 1; j < metrix[0].Length; j++) {
                if (metrix[0][j] == 0) {
                    setColToZero(metrix, j);
                }
            }

            if (rowHasZero)
                setRowToZero(metrix, 0);

            if (colHasZero) 
                setColToZero(metrix, 0);
        }

        public static int[][] randomMatrix(int M, int N, int min, int max)
        {
            int[][] matrix = new int[M][];
            Random random = new Random();
            for (int i = 0; i < M; i++)
            {
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

        public static void printMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < 10 && matrix[i][j] > -10)
                    {
                        Console.Write(" ");
                    }
                    if (matrix[i][j] < 100 && matrix[i][j] > -100)
                    {
                        Console.Write(" ");
                    }
                    if (matrix[i][j] >= 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" " + matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static int[][] cloneMatrix(int[][] matrix, int N) {
		    int[][] c = new int[matrix.Length][];

            for (int i = 0; i < matrix.Length; i++)
            {
                c[i] = new int[N];
            }

		    for (int i = 0; i < matrix.Length; i++) {
			    for (int j = 0; j < matrix[0].Length; j++) {
				    c[i][j] = matrix[i][j];
			    }
		    }
		    return c;
	    }
    }
}
