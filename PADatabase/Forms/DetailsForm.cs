using Microsoft.AspNetCore.Identity;
using PADatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PADatabase.Forms
{
    public  class DetailsForm
    {

        public UserPersonalDetails StudentDetails { get; set; }
        public bool IsChecked { get; set; }

        // Constructor to initialize the properties
        public DetailsForm(UserPersonalDetails StudentDetails, bool isChecked)
        {
            StudentDetails = StudentDetails;
            IsChecked = isChecked;
        }

        // Default constructor
        public DetailsForm() { }


    }
}
