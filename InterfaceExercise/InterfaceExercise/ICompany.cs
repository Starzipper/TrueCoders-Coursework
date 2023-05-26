using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string Make { get; set; }
        public int YearFounded { get; set; }
    }
}
