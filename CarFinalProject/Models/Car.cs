using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarFinalProject.Models
{
    public class Car
    {
        [Key]
        //Car  Id
        public int Id { get; set; }
        //Car Name
        public string Car_Name { get; set; }
        //Car Make
        public string Car_Make { get; set; }
        //Price of the Car
        public string Car_Price { get; set; }
    }
}
