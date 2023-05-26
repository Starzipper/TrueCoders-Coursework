/* joins: select all the computers from the products table:
using the products table and the categories table, return the product name and the category name */
SELECT products.Name, categories.CategoryID FROM products LEFT JOIN categories ON products.CategoryID = categories.CategoryID WHERE products.CategoryID = 1;
/* joins: find all product names, product prices, and products ratings that have a rating of 5 */
SELECT products.Name, products.Price, reviews.Rating FROM products LEFT JOIN reviews ON products.ProductID = reviews.ProductID WHERE reviews.Rating = 5;
/* joins: find the employee with the most total quantity sold.  use the sum() function and group by */
SELECT employees.FirstName, employees.LastName, SUM(sales.Quantity) FROM employees INNER JOIN sales ON employees.EmployeeID = sales.EmployeeID GROUP BY FirstName, LastName ORDER BY SUM(sales.Quantity) DESC;
/* joins: find the name of the department, and the name of the category for Appliances and Games */
SELECT departments.Name, categories.Name FROM categories LEFT JOIN departments ON categories.DepartmentID = departments.DepartmentID WHERE categories.CategoryID = 2 OR categories.CategoryID = 8;
/* joins: find the product name, total # sold, and total price sold,
 for Eagles: Hotel California --You may need to use SUM() */
SELECT products.Name, SUM(sales.Quantity), SUM(products.Price) FROM products INNER JOIN sales ON products.ProductID = sales.ProductID GROUP BY products.Name ORDER BY SUM(sales.Quantity) DESC, SUM(products.Price);
/* joins: find Product name, reviewer name, rating, and comment on the Visio TV. (only return for the lowest rating!) */
SELECT products.Name, reviews.Reviewer, reviews.Rating, reviews.Comment FROM products INNER JOIN reviews ON products.ProductID = reviews.ProductID WHERE products.ProductID = 857;

-- ------------------------------------------ Extra - May be difficult
/* Your goal is to write a query that serves as an employee sales report.
This query should return:
-  the employeeID
-  the employee's first and last name
-  the name of each product
-  and how many of that product they sold */
SELECT employees.EmployeeID, employees.FirstName, employees.LastName, products.Name AS ProductName, SUM(sales.Quantity)
FROM ((sales INNER JOIN employees ON sales.EmployeeID = employees.EmployeeID) INNER JOIN products ON sales.ProductID = products.ProductID)
GROUP BY employees.EmployeeID, employees.FirstName, employees.LastName, products.Name ORDER BY employees.LastName, SUM(sales.Quantity) DESC;