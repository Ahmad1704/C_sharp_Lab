namespace Day01_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] employees = new employee[3];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Please enter the employee id");
                employees[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter the employee salary");
                employees[i].salary = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter the Hiring  date");
                Console.WriteLine($"day");
                employees[i].HireDate.day = int.Parse(Console.ReadLine());
                Console.WriteLine($"month");
                employees[i].HireDate.month = int.Parse(Console.ReadLine());
                Console.WriteLine($"year");
                employees[i].HireDate.year = int.Parse(Console.ReadLine());
                Console.WriteLine($"please enter the employee gender enter 1 for male / 2 for female");
                int selectedNumber = int.Parse(Console.ReadLine());
                switch (selectedNumber)
                {
                    case 1:
                        employees[i].selectedGender = Gender.male; break;
                    case 2:
                        employees[i].selectedGender = Gender.female; break;
                    default:
                    break;
                }
               
                }
            for (int i = 0; i < employees.Length; i++)
            {

                Console.WriteLine($"employee {i+1} : id :{employees[i].id}");
                Console.WriteLine($"employee {i+1} : salary: {employees[i].salary}");
                Console.WriteLine($"employee {i+1} : Hiring date : {employees[i].HireDate.day}/{employees[i].HireDate.month}/{employees[i].HireDate.year}");
                Console.WriteLine($"employee {i+1} : Gender : {employees[i].selectedGender}");
            }
        }
    }
}
