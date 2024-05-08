using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PADatabase.Models
{
    public class CourseUser
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string UserId { get; set; }
        public virtual IdentityUser User { get; set; }

        public Guid CourseId { get; set; }
        public virtual Course Course { get; set; }


    }
}
