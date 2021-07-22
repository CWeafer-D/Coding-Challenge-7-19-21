using System;
using System.Collections.Generic;

namespace Coding_Challenge_7_19_21{

    public class Permute : IPermute{
        
        //List that Stores Permutations
        List<int[]> _perms = new List<int[]>();
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Permute(){
            
        }
        /// <summary>
        /// Swaps values in the given array based on the size of the array
        /// exchanges the first value then recursively calls itself to exchange the next point in the array
        /// the array is the reset for the next call in the for loop.
        /// if the end of the array is reached(start = end) that permutation is printed
        /// </summary>
        /// <param name="a"></param>
        /// <param name="Index">Always Starts = 0</param>
        public void FindPermutation(int[] a, int index)
        {
            int length = a.Length-1;
            if(index == length)
            {
                PrintPermuation(a);
                
            }
            else{
                for (int i = index; i <= length; i++){
                    Exchange(ref a[index], ref a[i]);
                    FindPermutation(a, index+1);
                    //reset array
                    Exchange(ref a[index], ref a[i]);
                }
            }
        }

        /// <summary>
        /// Switches 2 given array indexes
        /// </summary>
        /// <param name="a">a[index 1]</param>
        /// <param name="b">a[index 2]</param>
        public void Exchange(ref int first, ref int second)
        {
            int temp;
            temp = first;
            first = second;
            second = temp;
        }

        /// <summary>
        /// Prints out an individual permutation
        /// </summary>
        /// <param name="permutation"></param>
        public void PrintPermuation(int[] permutation)
        {
            Console.Write("["); 
            Console.Write(String.Join(",", permutation));
            Console.Write("]\n");
        }
        
    }

}


