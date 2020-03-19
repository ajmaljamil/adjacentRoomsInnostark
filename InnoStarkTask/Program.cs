using System;
using System.Collections.Generic;
using System.Linq;

namespace InnoStarkTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InnoStark Task!");
            GetCellState(new int[] { 0, 1, 1, 0, 0, 1, 0, 0 }, 2).ForEach(Console.WriteLine);
        }

        public static List<int> GetCellState(int[] cellBlockState, int days)
        {
            //if days are zero then we will have same pattern
            if (days == 0) 
                return cellBlockState.ToList();

            int n = cellBlockState.Length;

            //if only one item in array
            if(n==1)
            {
                if (cellBlockState[0] == 0)
                    return cellBlockState.ToList();
                else
                {
                    cellBlockState[0] = 0;
                    return cellBlockState.ToList();
                }
            }
            
            int[] tempArray = new int[n];
            Buffer.BlockCopy(cellBlockState, 0, tempArray, 0, n*sizeof(int));
            //cellBlockState.CopyTo(tempArray, 0);

            while(days-- > 0)
            {
                //for corner cases
                tempArray[0] = 0 ^ cellBlockState[1];
                tempArray[n - 1] = cellBlockState[n - 2] ^ 0;

                for (int i = 1; i <= n - 2; i++)
                    tempArray[i] = cellBlockState[i - 1] ^ cellBlockState[i + 1];

                // for next iteration 
                //tempArray.CopyTo(cellBlockState, 0);
                Buffer.BlockCopy(tempArray, 0, cellBlockState, 0, n * sizeof(int));
            }
            return cellBlockState.ToList();
        }
    }
}
