using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PADatabase.Models
{
    public class AssigmentStudent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; }

        public Guid? AssignmentId { get; set; }
        public virtual Assignment? Assignment { get; set; }

        public byte[]? PdfData { get; set; } // Nullable PDF Data

        public string? comments { get; set; }

        public DateTime? DueDate { get; set; }



        public bool? Status { get; set; }
    }
}
