using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class employee : IComparable
    {

        public int Id { get; set; }
        public string Name { get; set; }

        private int age;

        private int target;

        private int salary;

        public hiringDate HiringDate;

        public securityLevel SecurityLevel;

        public Gender Gender;


        public int Age
        {
            get { return age; }
            set
            {
                if (value > 18 && value < 45)
                    age = value;
            }
        }

        public int Target
        {
            get { return target; }
            set
            {
                if (value > 300)
                    target = value;
            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 6000 && value < 20000)
                    salary = value;
            }
        }


        public override string ToString()
        {
            return $"Id :{Id}  Name: {Name} , age {age} ,target {target},salary {salary}, Gender {Gender},hiringDate :{HiringDate.Day}/{HiringDate.Month}/{HiringDate.Year},securityLevel {SecurityLevel} ";
        }

        public int CompareTo(object? obj)
        {
            
            employee? emp = obj as employee;
            if (emp == null)
                throw new ArgumentException("Object is not an employee");

            if (HiringDate.Year > emp.HiringDate.Year)
                return 1;
            else if (HiringDate.Year < emp.HiringDate.Year)
                return -1;

            if (HiringDate.Month > emp.HiringDate.Month)
                return 1;
            else if (HiringDate.Month < emp.HiringDate.Month)
                return -1;

            if (HiringDate.Day > emp.HiringDate.Day)
                return 1;
            else if (HiringDate.Day < emp.HiringDate.Day)
                return -1;

            return 0; 
        }
    }
}