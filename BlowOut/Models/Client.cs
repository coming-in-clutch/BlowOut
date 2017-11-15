﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Client")]

    public class Client
    {
            [Key]
            public int clientID { get; set; }

            [Required]
            public String firstName { get; set; }

            [Required]
            public String lastName { get; set; }

            [Required]
            public String address { get; set; }

            [Required]
            public String city { get; set; }

            [Required]
            public String state { get; set; }

            [Required ]
            [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Please make sure the ZIP code has 5 digits")]
            public int zip { get; set; }

            [Required]
            [EmailAddress(ErrorMessage = "Please enter your email address in the following format: test@example.com")]
            public String emailAddress { get; set; }

            //[Required]
            //PUT IN SOMETHING TO VALIDATE THE PHONE NUMBER
            public String phone { get; set; }

        
    }
}