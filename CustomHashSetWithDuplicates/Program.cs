using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHashSetWithDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Employee> staff = new HashSet<Employee> 
            {
                new Employee { Emp_Id = 1, Emp_name = "Petko", Dept_name = "R&D" },
                new Employee { Emp_Id = 1, Emp_name = "Petko", Dept_name = "R&D" },
                new Employee { Emp_Id = 3, Emp_name = "Misho", Dept_name = "R&D" },
                new Employee { Emp_Id = 4, Emp_name = "Gogi", Dept_name = "R&D" },
                new Employee { Emp_Id = 5, Emp_name = "Dimo", Dept_name = "R&D" }
            };

            Console.WriteLine("{0} {1} {2}", "Id", "Employee", "Deptment");

            foreach (Employee employee in staff)
            { 
                Console.WriteLine("{0}  {1}        {2}", employee.Emp_Id, employee.Emp_name, employee.Dept_name);
            }
            
            
        }
    }
    
}
