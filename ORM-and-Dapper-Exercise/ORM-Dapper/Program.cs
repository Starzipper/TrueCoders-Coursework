namespace ORM_Dapper
{
    using System;
    using System.Data;
    using System.IO;
    using MySql.Data.MySqlClient;
    using Microsoft.Extensions.Configuration;
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string? connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            var productRepo = new DapperProductRepository(conn);
            productRepo.CreateProduct("Cheese", 5.99, 10);
            productRepo.UpdateProduct(4, "Macbook", 2200, 1);
            productRepo.DeleteProduct(940);
            IEnumerable<Product> products = productRepo.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}, ${product.Price}");
            }
        }
    }
}
