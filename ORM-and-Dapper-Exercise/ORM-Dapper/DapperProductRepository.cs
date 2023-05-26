using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM Products;");
        }
        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("INSERT INTO Products (Name, Price, CategoryID) VALUES (@productName, @productPrice, @catID);",
             new { productName = name, productPrice = price, catID = categoryID });
        }
        public void UpdateProduct(int id, string name, double price, int categoryID)
        {
            _connection.Execute("UPDATE Products SET Name = @productName, Price = @productPrice, CategoryID = @catID WHERE ProductID = @productID;",
             new { productName = name, productPrice = price, catID = categoryID, productID = id });
        }
        public void DeleteProduct(int id)
        {
            _connection.Execute("DELETE FROM Products WHERE ProductID = @productID; DELETE FROM Sales WHERE ProductID = @productID; DELETE FROM Reviews WHERE ProductID = @productID;",
             new { productID = id });
        }
    }
}
