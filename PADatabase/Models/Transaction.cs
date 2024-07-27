using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PADatabase.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateOnly? date_T { get; set; } 

        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; } 

        public double? amount { get; set; } 

        public string? comment { get; set; } 

   
    }
}
