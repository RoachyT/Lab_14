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
            Console.WriteLine($"\nCountin' dem 'Gators...\n");
            CountUntil.CountTheCounted(alligator, 3);
            Console.WriteLine($"\nCounting little fluffy Sheep...\n");
            CountUntil.CountTheCounted(sheep, 2);
            Console.WriteLine();
            CountUntil.CountTheCounted((Sheep)(sheep.Clone()), 3);
            Console.WriteLine();
            CountUntil.CountTheCounted(sheep, 1);
        }
    }
}
