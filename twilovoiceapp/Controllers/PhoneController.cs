using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Mvc;
using Twilio.Clients;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using twilovoiceapp.Models;

namespace twilovoiceapp.Controllers
{
    public class PhoneController : TwilioController
    {
        // GET: Phone
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MakeCall()
        {
            //var accountSid = "ACf86db5acfc97a1e5ad4e61244623b0a0";
            //var authToken = "06417b85b0daeaafc925fa0eb5c48e71";
            //TwilioClient.Init(accountSid, authToken);
            //var to = new PhoneNumber("+923323227986");
            //var from = new PhoneNumber("+16024974370");
            //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            //var call = CallResource.Create(
            //    to: to,
            //    from: from,
            //    url: new Uri("https://demo.twilio.com/welcome/voice.xml/"
            //    ));

            //return Content(call.Sid);
            return View();
        }
        // Get: ReceiveCall
        //public ActionResult ReceiveCall()
        //{
        //    var twiml = new TwilioResponse();
        //    return TwiML(twiml.Say("You are calling Marcos Placona").Dial(Settings.MyOwnNumber));
        //}

        // POST: MakeCall
        [HttpPost]
        public ActionResult MakeCall(string number)
        {
            var accountSid = "ACf86db5acfc97a1e5ad4e61244623b0a0";
            var authToken = "06417b85b0daeaafc925fa0eb5c48e71";
            TwilioClient.Init(accountSid, authToken);
            var to = new PhoneNumber(number);
            var from = new PhoneNumber("+16024974370");
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            var call = CallResource.Create(
                to: to,
                from: from,
                url: new Uri("https://demo.twilio.com/welcome/voice.xml/"
                ));

            return Content(call.Sid);
        }
    }

}