using System;
using System.Collections.Generic;
using System.Text;
using TooGoodDataParser.Utilities;

namespace TooGoodDataParser.Models
{
    internal class FormatOne
    {
        public int Identifier { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime OpenedDate { get; set; }
        public string Currency { get; set; }
        public string IdAndAccountCode { get; set; }
        public bool MyAccount { get; set; }
        public int AccountType { get; set; }
        public DateTime DateCreated { get; set; }
        public CurrencyType DollarType { get; set; }      
    }    
}