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
        /// <param name="start">Always = 0</param>
        /// <param name="end">set to the array Length - 1</param>
        public void FindPermuation(int[] a, int index)
        {
            int length = a.Length-1;
            if(index == length)
            {
                Console.Write("["); 
                Console.Write(String.Join(",", a));
                Console.Write("]\n");
                
            }
            else{
                for (int i = index; i <= length; i++){
                    exchange(ref a[index], ref a[i]);
                    FindPermuation(a, index+1);
                    //reset array
                    exchange(ref a[index], ref a[i]);
                }
            }
        }

        /// <summary>
        /// Switches 2 given array indexes
        /// </summary>
        /// <param name="a">a[index 1]</param>
        /// <param name="b">a[index 2]</param>
        public void exchange(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        
        public void printPermuations(int[] permutation)
        {
            Console.Write("["); 
            Console.Write(String.Join(",", permutation));
            Console.Write("]\n");
        }
        
    }

}


