using System;
namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product {Name= "Xbox", Price= 350 },
            new Product {Name= "Macbook", Price= 1000},
            new Product {Name= "Apple Watch", Price= 500},
            new Product {Name= "2012 Honda Fit", Price= 3500},

        };
        
        

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Access.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from SQL Data Access.");
        }
    }
}

