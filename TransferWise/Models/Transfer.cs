using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransferWise.Models
{
    public class Transfer
    {
        public int TransferID { get; set; }
        public string RecipientUserName { get; set; }
        public string SenderAccountName { get; set; }
        public int SenderAccountIndex { get; set; }
        public string Message { get; set; }
        public int Amount { get; set; }
    }
}