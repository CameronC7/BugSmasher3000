using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugSmasher3000.Models
{
    public partial class Employee
    {
        public Employee()
        {
            BugTicket = new HashSet<BugTicket>();
            LoginInfo = new HashSet<LoginInfo>();
        }
        
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PositionId { get; set; }


        public virtual Position Position { get; set; }
        public virtual ICollection<BugTicket> BugTicket { get; set; }
        public virtual ICollection<LoginInfo> LoginInfo { get; set; }
    }
}
