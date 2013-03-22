using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scratch.Models.Devices
{
    public class Card
    {
        public string Number { get; set; }
        public string CVV { get; set; }
        public string Name { get; set; }
        public string BillingStreetAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
    }
}