using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capicua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Capicua("step onno pets"));
        }

        static bool Capicua(string phrase)
        {
            int len = phrase.Length;
            for (int i = 0, j = phrase.Length - 1; i < phrase.Length; i++, j--)
            {
                if (phrase[i] != phrase[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
