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
        }

        //Method 1:go through, using sets or bool[] to save i, j values, go through bool[], set i/j row/column to 0.
        //O(m*n) time, O(m+n) space
        static void setZerosofMetrix(int[][] metrix) { 
            bool[] row = new bool[metrix[0].Length];
            bool[] col = new bool[metrix.Length];

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
            for (int i = 0; i < metrix[0].Length; i++) {
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
    }
}
