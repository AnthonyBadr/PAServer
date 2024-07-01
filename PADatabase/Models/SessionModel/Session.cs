using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PADatabase.Models.SessionModel
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public double Nbhours { get; set; }

        public string Location { get; set; }

        public string description { get; set; }

        public double PackageCodeListId { get; set; }


    }
}
