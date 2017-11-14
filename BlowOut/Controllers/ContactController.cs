using BlowOut.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        private BlowOutContext db = new BlowOutContext();

        // GET: Contact
        public String Index()
        {
            //Default display when the user calls the Contact controller
            return "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
        }
       
        public String Email(string name, string email)
        {
            //What is returned when the user enters their name and email
            return HttpUtility.HtmlEncode("Thank you " + name 
                + ". We will send an email to " + email);
            
        }
    }
}