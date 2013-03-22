using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scratch.Models.Transactions
{
    public class TransactionResult
    {
        public bool IsValid { get; set; }
        public bool Success { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
    }
}