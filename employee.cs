using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day01_lab
{
        public enum Gender { male ,female}
    internal struct employee
    {
        public int id;
        public int salary;
        public hireDate HireDate;
        public Gender selectedGender;
    }
}
