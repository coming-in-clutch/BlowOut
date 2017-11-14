using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int instrumentID { get; set; }
        public int clientID { get; set; }

        [Required(ErrorMessage = "Please enter an instrument description")]
        public String instrumentDesc { get; set; }
        public String type { get; set; }
        [Required(ErrorMessage = "Please enter a price")]
        public decimal? price { get; set; }
    }
}