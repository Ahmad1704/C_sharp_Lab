using ClassLibrary;
using System.Reflection;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] employees = new employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new employee();
                Console.WriteLine($"Please enter the employee id");
                employees[i].Id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter the employee Name");
                employees[i].Name = Console.ReadLine();
                do
                {
                    Console.WriteLine($"Please enter the employee salary");
                    employees[i].Salary = int.Parse(Console.ReadLine());
                } while (!(employees[i].Salary < 6000 && employees[i].Salary > 20000));

                do
                {
                    Console.WriteLine($"Please enter the employee Target");
                    employees[i].Target = int.Parse(Console.ReadLine());
                } while (!(employees[i].Target <300));

                do
                {
                    Console.WriteLine($"Please enter the employee age");
                    employees[i].Age = int.Parse(Console.ReadLine());
                } while (!(employees[i].Age < 18 && employees[i].Salary < 45));

                Console.WriteLine($"Please enter the Hiring  date");
                Console.WriteLine($"day");
                employees[i].HiringDate.Day = int.Parse(Console.ReadLine());
                Console.WriteLine($"month");
                employees[i].HiringDate.Month = int.Parse(Console.ReadLine());
                Console.WriteLine($"year");
                employees[i].HiringDate.Year = int.Parse(Console.ReadLine());
                Console.WriteLine($"please enter the employee gender enter 1 for male / 2 for female");
                int selectedNumber = int.Parse(Console.ReadLine());
                switch (selectedNumber)
                {
                    case 1:
                        employees[i].Gender = Gender.Male; break;
                    case 2:
                        employees[i].Gender = Gender.Female; break;
                    default:
                        break;
                }
                Console.WriteLine($"please enter the employee Security Level enter 1 for admin / 2 for hr, /3 for officer");
                int selectedNumber1 = int.Parse(Console.ReadLine());
                switch (selectedNumber1)
                {
                    case 1:
                        employees[i].SecurityLevel = securityLevel.admin; break;
                    case 2:
                        employees[i].SecurityLevel = securityLevel.hr; break;
                    case 3:
                        employees[i].SecurityLevel = securityLevel.officer; break;
                    default:
                        break;
                }

            }

            Console.WriteLine("before");
            foreach(employee emp in employees)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("after");

            Array.Sort(employees);

            foreach (employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }


    }
}