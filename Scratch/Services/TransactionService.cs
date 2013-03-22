using Scratch.Models.Devices;
using Scratch.Models.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scratch.Services
{
    public interface ITransactionService
    {
        TransactionResult ProcessTransaction();
        bool AuthorizeCard();
        bool IsDeviceValid { get; }
    }

    public class TransactionService : ITransactionService
    {
        private IDevice _device;

        public bool IsDeviceValid
        {
            get
            {
                return true;
            }
        }

        public TransactionService(IDevice device)
        {
            _device = device;
        }

        public TransactionResult ProcessTransaction()
        {
            return new TransactionResult();
        }

        public bool AuthorizeCard()
        {
            return false;
        }
    }
}