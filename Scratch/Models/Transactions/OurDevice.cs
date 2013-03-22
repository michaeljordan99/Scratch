using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scratch.Models.Transactions;

namespace Scratch.Models.Devices
{
    public class OurDevice : IDevice
    {
        public string MyTypeName
        {
            get
            {
                return this.GetType().ToString();
            }
        }
    }
}