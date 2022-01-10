using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        
        public string FirstName { get; set; }
   
        public string LastName { get; set; }
  
        public string Gender { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string Designation { get; set; }

        public string TechStack { get; set; }
    
        public DateTime? DateOfJoining { get; set; }
    }
}
