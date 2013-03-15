using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scratch.Repositories;

namespace Scratch.Services
{
    public class MessageService : IMessageService
    {
        private readonly IRepository _repository;

        public MessageService(IRepository repository)
        {
            _repository = repository;
        }

        public string GetMessage()
        {
            //return "Hello Ninject with ASP.Net MVC 3";
            return _repository.GetMessages().First();
        }
    }
}