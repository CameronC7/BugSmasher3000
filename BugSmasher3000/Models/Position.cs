using System;
using System.Collections.Generic;

namespace BugSmasher3000.Models
{
    public partial class Position
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
            LoginInfo = new HashSet<LoginInfo>();
        }

        public int PositionId { get; set; }
        public string PosTitle { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<LoginInfo> LoginInfo { get; set; }
    }
}
