using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Alligator : ICountable
    {
        public int Count = 0;
        public string Name = "alligator";
        public Alligator()
        {
           
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
        public string GetName()
        {
            return Name;
        }
    }
}
