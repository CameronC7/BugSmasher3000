using System;
using System.Collections.Generic;

namespace BugSmasher3000.Models
{
    public partial class BugTicket
    {
        public int BugId { get; set; }
        public string Title { get; set; }
        public string BugDesc { get; set; }
        public int Severity { get; set; }
        public int? EmpId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompDate { get; set; }

        public virtual Employee Emp { get; set; }
    }
}
