using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List.");
            return new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data from a List database.");
        }
    }
}
