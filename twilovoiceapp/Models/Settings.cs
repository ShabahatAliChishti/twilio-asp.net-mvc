using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace twilovoiceapp.Models
{
    public class Settings
    {
        public static string AccountSid = Environment.GetEnvironmentVariable("ACf86db5acfc97a1e5ad4e61244623b0a0");
        public static string AuthToken = Environment.GetEnvironmentVariable("06417b85b0daeaafc925fa0eb5c48e71");
        public static string MyOwnNumber = Environment.GetEnvironmentVariable("+923323227986");
        public static string MyTwilioNumber = Environment.GetEnvironmentVariable("+16024974370");

    }
}
    
