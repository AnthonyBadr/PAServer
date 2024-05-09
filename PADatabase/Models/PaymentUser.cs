﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PADatabase.Models
{
    public class PaymentUser
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Indicates that the value is generated by the database
        public Guid Id { get; set; }

        public double payment {  get; set; }

        public string? UserId { get; set; }
        public virtual IdentityUser User { get; set; }

    }
}
