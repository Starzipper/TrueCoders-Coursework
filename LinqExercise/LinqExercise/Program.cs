using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine($"Sum of numbers: {numbers.Sum()}");

            //TODO: Print the Average of numbers
            Console.WriteLine($"Average of numbers: {numbers.Average()} \n");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine($"Numbers in ascending order: ");
            foreach (int num in numbers.OrderBy(number => number))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine($"Numbers in descending order: ");
            foreach (int num in numbers.OrderByDescending(number => number))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine($"Numbers greater than 6: ");
            foreach (int num in numbers.Where(number => number > 6))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine($"Only 4 of the numbers should be printed: ");
            foreach (int num in numbers.OrderBy(number => number).Take(4))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 22;
            Console.WriteLine("Numbers in descending order after my age is added: ");
            foreach (int num in numbers.OrderByDescending(number => number))
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Employees with first names starting with 'C' or 'S': ");
            foreach (var employee in employees.Where(name => name.FirstName.StartsWith('C') || name.FirstName.StartsWith('S')).OrderBy(name => name.FirstName))
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine("");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over age 26: ");
            foreach (var employee in employees.Where(person => person.Age > 26).OrderBy(person => person.Age).ThenBy(person => person.FirstName))
            {
                Console.WriteLine($"{employee.FullName}, {employee.Age}");
            }
            Console.WriteLine("");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            int sum = 0;
            int avgCount = 0;
            foreach (var employee in employees.Where(employee => employee.YearsOfExperience <= 10 && employee.Age > 35))
            {
                sum += employee.YearsOfExperience;
                avgCount++;
            }
            Console.WriteLine("Applying to employees greater than 35 years of age and with less than or equal to 10 years of experience: ");
            Console.WriteLine($"Sum of employees' years of experience: {sum}");
            Console.WriteLine($"Average of employees' years of experience: {((avgCount > 0) ? (sum/avgCount) : 0)}");
            Console.WriteLine("");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees.Append(new Employee());

            var squares = Enumerable.Range(1, 100).Average(x => x*x);
            Console.WriteLine(squares);


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
