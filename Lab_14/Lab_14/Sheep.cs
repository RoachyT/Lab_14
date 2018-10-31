using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Sheep : ICloneable, ICountable
    {
        public int Count { get; set; }
        public string Name { get; set; }
        public Sheep(string name)
        {
            Name = name;
        }
        public string GetName()
        {
          
            return $"{Name}";
        }
        public object Clone()
        {
            Sheep newSheep = new Sheep("Baby Bertha");
            
            return newSheep;
        }
        public void IncrementCount()
        {
            Count++;
        }
        public void ResetCount()
        {
            Count = 0;
        }
        public int GetCount()
        {
            return Count;
        }
        public string GetCountString()
        {
            return Count.ToString();
        }
      
    }
}
