using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugSmasher3000.Models
{
    public interface IEmployee
    {
        IQueryable<Employee> Employee { get; }
    }
}
