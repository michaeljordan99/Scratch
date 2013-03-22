using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Scratch.Provider
{
    class DeviceProvider : IProvider
    {
        private object _device;

        public object Create(IContext context)
        {
            var deviceType = ConfigurationManager.AppSettings["DeviceType"];
            _device = Activator.CreateInstance(Type.GetType(deviceType));
            return _device;
        }

        public Type Type
        {
            get 
            { 
                return _device.GetType(); 
            }
        }
    }
}