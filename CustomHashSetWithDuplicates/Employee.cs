using System;
using System.Collections.Generic;
using System.Text;

namespace CustomHashSetWithDuplicates
{
    public class Employee : IEquatable<Employee>
    {
        public int Emp_Id { get; set; }

        public string Emp_name { get; set; }

        public string Dept_name { get; set; }

        public bool Equals(Employee employee)
        {
            return Emp_Id.Equals(employee.Emp_Id);
        }
        public override int GetHashCode()
        {
            return Emp_Id.GetHashCode();
        }
    }
}
