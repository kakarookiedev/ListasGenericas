using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace testeListas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("HOW MANY EMPLOYEES WILL BE REGISTERED? ");
                int employeesCount = int.Parse(Console.ReadLine());
                List<Employee> list = new List<Employee>();
                double salary = 0.0; int id = 0; string name = "";
                int salIncreased = 0;
                for (int i = 0; i < employeesCount; i++)
                {
                    Console.WriteLine($"\nEMPLOYEE #{i + 1}:");
                    Console.Write("Id: ");
                    id = (int.Parse(Console.ReadLine()));
                    Console.Write("Name: ");
                    name = (Console.ReadLine());
                    Console.Write("Salary: R$");
                    salary = (double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    list.Add(new Employee(id, name, salary));
                }

                Console.Write("ENTER THE EMPLOYEE ID THAT WILL HAVE SALARY INCREASED: ");
                salIncreased = int.Parse(Console.ReadLine());

                Console.Write("ENTER THE PERCENTAGE: ");
                double plusId = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee employee = new Employee(id, name, salary);

                Employee emp = list.Find(x => x.Id == salIncreased);

                if (emp != null)
                {
                    emp.Increase(plusId);
                }
                foreach (Employee obj in list)
                {
                    Console.WriteLine(obj);
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}