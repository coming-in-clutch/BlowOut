﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public String Index()
        {
            return "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
        }
       
        public String Email(string name, string emailAddress)
        {
            
            return HttpUtility.HtmlEncode("Thank you " + name 
                + ". We will send an email to " + emailAddress);
            
        }
    }
}