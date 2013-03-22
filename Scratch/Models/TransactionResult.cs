//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scratch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionResult
    {
        public int TransactionResultId { get; set; }
        public string TransactionId { get; set; }
        public Nullable<bool> ResultStatus { get; set; }
        public string ResultMessage { get; set; }
        public string TransactionType { get; set; }
        public string ApprovalNumberResult { get; set; }
        public string BatchNumber { get; set; }
        public string BillingName { get; set; }
        public string AVSResponseCode { get; set; }
        public string AVSResponseText { get; set; }
        public string CVVResponseCode { get; set; }
        public string CVVResponseText { get; set; }
        public Nullable<decimal> AmountBalance { get; set; }
        public Nullable<decimal> AmountBill { get; set; }
        public Nullable<decimal> AmountFee { get; set; }
        public string AccountCardType { get; set; }
        public string AccountExpiryDate { get; set; }
        public string MaskedAccount { get; set; }
        public string AccountEntryMethod { get; set; }
        public string UniqueTransID { get; set; }
        public string Signature { get; set; }
        public string AccountHash { get; set; }
        public Nullable<decimal> AmountProcessed { get; set; }
    }
}
