using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scratch.Models.Transactions;

namespace Scratch.Models.Devices
{
    public class TheirDevice : IDevice
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