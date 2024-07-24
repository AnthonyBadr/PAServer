using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Globalization;


namespace PADatabase.Models
{
    public class UserPersonalDetails
    {
        [Key]
        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public double numberOfHours { get; set; }

        public ICollection<UserSummaries> UserSummaries { get; set; }

        public ICollection<Infromation> Infromation { get; set; }
    }
}
