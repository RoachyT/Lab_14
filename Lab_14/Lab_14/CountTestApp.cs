using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class CountTestApp
    {
        Alligator alligator = new Alligator();
        Sheep sheep = new Sheep("Big Bertha");
        CountUntil countUntil = new CountUntil();
        public CountTestApp()
        {
            Console.WriteLine($"Counting Alligator...");
            CountUntil.CountTheCounted(alligator, 3);
            Console.WriteLine($"Counting Sheep...");
            CountUntil.CountTheCounted(sheep, 2);
            CountUntil.CountTheCounted((Sheep)(sheep.Clone()), 3);
            CountUntil.CountTheCounted(sheep, 1);
        }

       
        
           
        
       
        
        
    }
}
