using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_words_in_a_row
{
    class Program
    {
        static void Main(string[] args)
        {
            string add = "h1gf        h2tf h3hf h444vf    a55af f66fkh q77qkjh ln88nh";
            char b = ' ';
            int c = 0;
            bool f = false;
            foreach (int i in add)
            {
                if (i == b)
                {
                    if (f == false)
                    {
                        c = c + 1;
                    }
                    f = true;
                }
                else
                {
                    f = false;
                }
            }
            Console.WriteLine(c + 1);
            Console.ReadKey();
        }
    }
}
