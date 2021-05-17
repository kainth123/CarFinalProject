using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarFinalProject.Models
{
    public class Staff
    {
        [Key]
        //Staff Id
        public int Id { get; set; }
        //Staff Name
        public string Staff_Name { get; set; }
        //Staff Address
        public string Staff_Address { get; set; }
        //Staff Contact
        public string Staff_Contact { get; set; }
    }
}
