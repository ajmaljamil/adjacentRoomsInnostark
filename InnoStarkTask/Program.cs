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
            //if days are zero then we will have same pattern also when we don't have item then we will return empty list
            if (days == 0 || cellBlockState.Length == 0) 
                return cellBlockState.ToList();

            int sizeOfArray = cellBlockState.Length;

            //if only one item in array
            if(sizeOfArray==1)
            {
                if (cellBlockState[0] == 0)
                    return cellBlockState.ToList();
                else
                {
                    //when we will have value = 1 for a single item array after first day it will be set to zero always 
                    cellBlockState[0] = 0;
                    return cellBlockState.ToList();
                }
            }
            
            int[] tempArray = new int[sizeOfArray];
            //BlockCopy is aimed at fast byte-level primitive array copying 
            Buffer.BlockCopy(cellBlockState, 0, tempArray, 0, sizeOfArray*sizeof(int));

            while(days-- > 0) //Loop until then end of days
            {
                //for corner rooms
                tempArray[0] = 0 ^ cellBlockState[1];
                tempArray[sizeOfArray - 1] = cellBlockState[sizeOfArray - 2] ^ 0;

                //check for rooms which are not the cornors and update their value using XOR operator
                for (int i = 1; i <= sizeOfArray - 2; i++)
                    tempArray[i] = cellBlockState[i - 1] ^ cellBlockState[i + 1];

                // for next iteration 
                Buffer.BlockCopy(tempArray, 0, cellBlockState, 0, sizeOfArray * sizeof(int));
            }
            return cellBlockState.ToList();
        }
    }
}
