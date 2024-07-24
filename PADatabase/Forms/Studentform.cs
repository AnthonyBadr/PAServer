using Microsoft.AspNetCore.Identity;
using System;

namespace PADatabase.Forms
{
    public class Studentform
    {
        public IdentityUser Student { get; set; }
        public bool IsChecked { get; set; }

        // Constructor to initialize the properties
        public Studentform(IdentityUser student, bool isChecked)
        {
            Student = student;
            IsChecked = isChecked;
        }

        // Default constructor
        public Studentform() { }
    }
}
