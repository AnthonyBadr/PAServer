using System;
using System.ComponentModel.DataAnnotations;

namespace PADatabase.Models
{
    public class UserSummaries
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; }

        [Required]
        public double Money { get; set; }

        [Required]
        public int PaymentNumber { get; set; }

        [Required]
        public double NbHours { get; set; }


        public double  AmountPaid {get; set;}
        public string Status { get; set; }

        // Navigation property

        public virtual ICollection<Session> Sessions { get; set; }
        public virtual UserPersonalDetails UserPersonalDetail { get; set; }

        // Default constructor
        public UserSummaries()
        {
            // Initialize properties if needed
        }

        // Parameterized constructor
        public UserSummaries(Guid id, string userId, double money, int paymentNumber, double nbHours, string status, double amountPaid)
        {
            Id = id;
            UserId = userId;
            Money = money;
            PaymentNumber = paymentNumber;
            NbHours = nbHours;
            Status = status; // Remains as string
            AmountPaid = amountPaid;
        }
    }
}


