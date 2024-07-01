using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PADatabase.Models.SessionModel
{
    public class PackageCodeList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Pckg_Name { get; set; }  

        public string Description { get; set; }

        public double Price { get; set; }
        
    }
}
