using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course.Entities;
using System.IO;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER FULL PATH: ");
            string path = Console.ReadLine();
            Console.Write("ENTER IN SALARY: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Create list in employee
            List<Employees> emp = new List<Employees>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    emp.Add(new Employees(name, email, salary));

                    var emails = emp.Where(e => e.Salary > limit).OrderBy(e => e.Email).Select(e => e.Email);
                    var sum = emp.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                    Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));

                    foreach (string Email in emails)
                    {
                        Console.WriteLine(email);
                    }
                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

                    Console.ReadKey();
                }
            }
        }
    }
}
