﻿using BlowOut.DAL;
using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        private BlowOutContext db = new BlowOutContext();

        public ActionResult Index()
        {
            return View();
        }

        //this gets the auto-incremented ID to put later into the post create method
        [HttpGet]

        public ActionResult Create(int ID)
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "clientID,firstName,lastName,address,city,state,zip,emailAddress,phone")] Client client, int ID)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);

                //commites new client to database
                db.SaveChanges();

                //lookup instrument
                Instrument instrument = db.Instruments.Find(ID);

                //update instrument
                instrument.clientID = client.clientID;

                //save changes
                db.SaveChanges();

                return RedirectToAction("Summary", new { client.clientID, instrument.instrumentID });

            }

            return View(client);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Rentals()
        {
            //return View();
            return View(db.Instruments.ToList());
        }

        //the way to pass all of the instrument information to the view
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

         //this summary view takes in the client models and finds the ID that gets passed into the view, it will then take that ID with all of the data associated with 
        //each individual id and load it up into the viewbag to later access the attributes
        public ActionResult Summary(int clientID, int instrumentID)
        {
            Client client = db.Clients.Find(clientID);
            Instrument instrument = db.Instruments.Find(instrumentID);

            ViewBag.Client = client;
            ViewBag.Instrument = instrument;


            return View();
        }



    }
}