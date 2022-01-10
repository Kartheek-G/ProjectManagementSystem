using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PresentationLayer.Repository.Entities
{
    public partial class Project
    {
        public Project()
        {
            Allocations = new HashSet<Allocation>();
        }

        [Key]
        public int ProjectId { get; set; }
        [StringLength(50)]
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        [StringLength(50)]
        public string ProjectStatus { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [InverseProperty(nameof(Allocation.Project))]
        public virtual ICollection<Allocation> Allocations { get; set; }
    }
}
