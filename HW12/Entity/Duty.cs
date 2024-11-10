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
        public string Priority { get; set; }
        public int Status { get; set; }
        public int StatusId { get; set; }
        public DateTime EndTime { get; set; }
    }
}
