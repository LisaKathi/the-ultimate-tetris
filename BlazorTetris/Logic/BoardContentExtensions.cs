using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTetris.Logic
{
    public delegate bool CancelableIterator(int row, int col);
    public delegate void Iterator(int row, int col);

    public static class BoardContentExtensions
    {

        public static bool Iterate(this string[,] matrix, CancelableIterator iterator)
        {
            for (var row = 0; row < matrix.GetLength(0); row++)
            {
                for (var col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!iterator(row, col))
                    {
                        return false;

                    }

                }
            }
            return true;

        }
        public static void Iterate(this string[,] matrix, Iterator iterator) =>
            Iterate(matrix, (row, col) => { iterator(row, col); return true; });

    }
    

    
    
}
