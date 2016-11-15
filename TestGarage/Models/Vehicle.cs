using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestGarage.Models
{
    public class Vehicle
    {
        [Key]
        public string RegNum { get; set; }

        public string SSN { get; set; }

        [ForeignKey("SSN")]
        public Person Owner { get; set; }
    }
}