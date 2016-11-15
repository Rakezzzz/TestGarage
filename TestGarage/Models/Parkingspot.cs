using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestGarage.Models
{
    public class Parkingspot
    {
        [Key]
        public int ParkId { get; set; }

        public string RegNum { get; set; }
        [ForeignKey("RegNum")]
        public Vehicle ParkedVehicle { get; set; }

        public string SSN { get; set; }
        [ForeignKey("SSN")]
        public Person Renter { get; set; }

    }
}