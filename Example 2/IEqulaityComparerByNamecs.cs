using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_1_C__Advance.NewFolder
{
    internal class IEqulaityComparerByNamecs : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? emp1, Employee? emp2)
        {
            if (ReferenceEquals(emp1, emp2)) { return true; }
            if (emp1 is null || emp2 is null){ return false; }
            return string.Equals(emp1.Name , emp2.Name , StringComparison.OrdinalIgnoreCase);


        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            //return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name ?? 0 );   
            return obj.Name is null ? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name);
        }
    }
}
