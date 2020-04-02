using System;
using System.Collections.Generic;

namespace BugSmasher3000.Models
{
    public partial class LoginInfo
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int EmpId { get; set; }
        public int PositionId { get; set; }

        public virtual Employee Emp { get; set; }
        public virtual Position Position { get; set; }
    }
}
