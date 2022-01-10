using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PresentationLayer.Repository.Entities
{
    public partial class Allocation
    {
        [Key]
        public int AllocationId { get; set; }
        public int? ProjectId { get; set; }
        public int? EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("Allocations")]
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(ProjectId))]
        [InverseProperty("Allocations")]
        public virtual Project Project { get; set; }
    }
}
