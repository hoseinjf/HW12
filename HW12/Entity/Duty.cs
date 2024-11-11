using HW12.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.Entity
{
    public class Duty
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityId { get; set; }
        public EnumPriority Priority { get; set; }
        public int StatusId { get; set; }
        public EnumStatus Status { get; set; }
        public DateTime EndTime { get; set; }
    }
}
