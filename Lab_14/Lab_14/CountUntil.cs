using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class CountUntil
    {
   
        public CountUntil()
        {
        }

        public static void CountTheCounted(ICountable c, int MaxCount)
        {
            
            for (int i = 0; i < MaxCount; i++)
            {
                c.IncrementCount();
                Console.WriteLine($"{c.GetCount()} {c.GetName()}");
            }
            c.ResetCount();
        }
    }
}
