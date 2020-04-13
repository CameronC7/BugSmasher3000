using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugSmasher3000.Models
{
    public class EFEmployeeRepository : IEmployee
    {
        private BugSmasherDataContext context;

        public EFEmployeeRepository(BugSmasherDataContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employee> Employee => context.Employee;
    }
}
