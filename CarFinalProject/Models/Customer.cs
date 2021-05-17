using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarFinalProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        //Name of the Customer
        public string Customer_Name { get; set; }
        //Address of the customer
        public string Customer_Address { get; set; }
        //Contact number of the customer
        public string Customer_Contact { get; set; }
        //Foreign Key
        //public int HospitalID { get; set; }
        //public Hospital Hospital_obj { get; set; }
        //Foreign Key
        public int StaffID { get; set; }
        public Staff Staff_ID { get; set; }
    }
}
