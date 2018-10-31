using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    interface ICountable
    {
        void IncrementCount();
        void ResetCount();
        int GetCount();
        string GetCountString();
        string GetName();
    }
}
