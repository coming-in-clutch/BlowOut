using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult Instrument(String sInstrument, int iUsed, int iNew, String sImage)
        {
            switch (sInstrument)
            {
                case ("Trumpet"):
                    ViewBag.instrumentName = sInstrument;
                    ViewBag.usedPrice = iUsed;
                    ViewBag.newPrice = iNew;
                    ViewBag.instrumentImage = sImage;
                    break;
                case ("Trombone"):
                    ViewBag.instrumentName = sInstrument;
                    ViewBag.usedPrice = iUsed;
                    ViewBag.newPrice = iNew;
                    ViewBag.instrumentImage = sImage;
                    break;
                case ("Tuba"):
                    ViewBag.instrumentName = sInstrument;
                    ViewBag.usedPrice = iUsed;
                    ViewBag.newPrice = iNew;
                    ViewBag.instrumentImage = sImage;
                    break;
                case ("Flute"):
                    ViewBag.instrumentName = sInstrument;
                    ViewBag.usedPrice = iUsed;
                    ViewBag.newPrice = iNew;
                    ViewBag.instrumentImage = sImage;
                    break;
                case ("Clarinet"):
                    ViewBag.instrumentName = sInstrument;
                    ViewBag.usedPrice = iUsed;
                    ViewBag.newPrice = iNew;
                    ViewBag.instrumentImage = sImage;
                    break;
                case ("Saxophone"):
                    ViewBag.instrumentName = sInstrument;
                    ViewBag.usedPrice = iUsed;
                    ViewBag.newPrice = iNew;
                    ViewBag.instrumentImage = sImage;
                    break;

            }
            return View();
        }
    }
}