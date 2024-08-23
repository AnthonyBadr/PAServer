using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PADatabase.Models
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string UserId { get; set; }



        [ForeignKey("UserId")]
        public virtual UserPersonalDetails User { get; set; }

        public string? Location { get; set; }

        public string description { get; set; }

        public Guid PackageCodeListId { get; set; }

        [ForeignKey("PackageCodeListId")]
        public virtual PackageCodeList PackageCodeList { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }
        public DateOnly DateofLesson { get; set; } // Date variable


        public virtual ICollection<SessionStudent> SessionStudents { get; set; }
        public virtual UserSummaries UserSummaries { get; set; }

        public Guid? UserSummariesId { get; set; }

        public int SNumber { get; set; }

    }       

    }

    