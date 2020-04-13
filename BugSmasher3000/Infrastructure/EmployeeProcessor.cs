using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugSmasher3000.Models;

namespace BugSmasher3000.Infrastructure
{
    public static class EmployeeProcessor
    {
        public static Employee CreateEmployee(string firstName, string lastName, string email, int positionID)
        {
            Employee data = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PositionId = positionID
            };

            return data;
        }

    }
}
