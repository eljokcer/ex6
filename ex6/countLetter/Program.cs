using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountLetter("hello world", 'l'));

        }

        static int CountLetter(string sentence, char letter)
        {
            int counter = 0;
            int len = sentence.Length;
            for (int i = 0; i < len; i++)
            {
                if (sentence[i]==letter)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
