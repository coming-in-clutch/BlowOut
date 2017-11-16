using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class ClientInstrument
    {
        [Key]
        public int clientID { get; set; }
        public String instrumentDesc { get; set; }
        public String type { get; set; }
        [Required(ErrorMessage = "Please enter a price")]
        public decimal? price { get; set; }
    }
}