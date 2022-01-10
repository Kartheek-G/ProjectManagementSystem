using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class AllocationModel
    {
        public int AllocationId { get; set; }
        public int? ProjectId { get; set; }
        public int? EmployeeId { get; set; }
    }
}
