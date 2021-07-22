using System;

namespace Coding_Challenge_7_19_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Object Declaration and Object Declaration
            int[] a = new int[]{10,20,30};
            IPermute p = new Permute();
            //FindPermutation(array to calculate, initial array index)
            p.FindPermutation(a, 0);
        }
    }
}
