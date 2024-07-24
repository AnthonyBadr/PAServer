using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PADatabase.Models
{
    public class SessionStudent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid SessionId {  get; set; }
        
        public virtual Session Session { get; set; }

        public string UserId { get; set; }


        [ForeignKey("UserId")]
        public virtual UserPersonalDetails User { get; set; }



    }
}
