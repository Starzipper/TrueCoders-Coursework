using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL.");
            return new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL database.");
        }
    }
}
