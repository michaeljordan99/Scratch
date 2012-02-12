using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scratch.Repositories
{
    public class Repository : IRepository
    {
        public List<string> GetMessages()
        {
            return new List<string>() { "Hello Ninject with ASP.Net MVC 3 From the Repository", "Second Message" };
        }
    }
}