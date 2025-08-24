using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1_C__Advance.NewFolder
{
    internal class Employee : IEquatable<Employee>
    {
      

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }


        public Employee(int id, string? name, int salary)
        {
            Id = id;
            Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        }



        public bool Equals(Employee? employee)
        {
            if(employee is not null)
            {
                return employee.Name == Name && employee.Salary == Salary && employee.Id == Id  ;
            }
            else
                return false ;
            
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name , Id , Salary);
        }
    }
}
