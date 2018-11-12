using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("hello"));
        }

        static string Reverse(string word)
        {
            string str = "";
            for (int i = 0; i < word.Length; i++)
            {
                str = word[i] + str;
            }
            return str;
        }
    }
}
