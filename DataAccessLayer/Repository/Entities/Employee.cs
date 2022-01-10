using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PresentationLayer.Repository.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            Allocations = new HashSet<Allocation>();
        }

        [Key]
        public int EmployeeId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Gender { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string MobileNumber { get; set; }
        [StringLength(50)]
        public string Designation { get; set; }
        [StringLength(50)]
        public string TechStack { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateOfJoining { get; set; }

        [InverseProperty(nameof(Allocation.Employee))]
        public virtual ICollection<Allocation> Allocations { get; set; }
    }
}
