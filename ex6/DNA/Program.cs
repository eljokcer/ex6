using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindSubSequence("atgcttcggcaagactc", "hbv"));
        }

        static bool FindSubSequence (string sequence, string sub)
        {
            for(int i=0;i<= sequence.Length-sub.Length;i++)
            {
                if(sequence.Substring(i,sub.Length)==sub)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
