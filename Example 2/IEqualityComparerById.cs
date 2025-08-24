using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1_C__Advance.NewFolder
{
    internal class IEqualityComparerById : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? emp1, Employee? emp2)
        {
            if (ReferenceEquals(emp1, emp2)) return true;
            if (emp1 is null   ||  emp2 is null) return false;
            return emp1.Id == emp2.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
