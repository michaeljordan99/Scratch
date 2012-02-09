using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Scratch.Services;

namespace Scratch.Tests.Mocks
{
    public class MessageServiceMock : IMessageService
    {
        public string GetMessage()
        {
            return "Home Controller Message from Mock";
        }
    }
}
