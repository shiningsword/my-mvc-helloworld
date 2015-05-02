using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransferWise.Models
{
    public class TransferViewModel
    {
        public Transfer TransferData { get; set; }
        public SelectList RecipientList { get; set; }

    }
}