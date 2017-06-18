using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgs
{
    public static class Sorting
    {
        public static int[] BubbleSort(int[] num, bool asc = true)
        {
            int temp; // holding variable
            bool flag = true; // set to true to begin first pass
            int[] output; // final output to return
            
            while(flag)
            {
                flag = false; // set flag to false awaiting a possible swap
                for(int i = 0; i < num.Length - 1; i++)
                {
                    if(asc)
                    {
                        // ascending order
                        if(num[i] > num[i + 1])
                        {
                            temp = num[i]; // store the current number in a variable
                            num[i] = num[i + 1]; // set current number to next number in array
                            num[i + 1] = temp; // set next number to the temp variable
                            flag = true; // indicate a swap has occured
                        }
                    }
                    else
                    {
                        // descending order
                        if(num[i] < num[i + 1])
                        {
                            temp = num[i];
                            num[i] = num[i + 1];
                            num[i + 1] = temp;
                            flag = true;
                        }
                    }

                }
            }

            return output = num;
        }
    }
}
