using System;
using System.Collections.Generic;
using System.Text;
using TooGoodDataParser.Utilities;

namespace TooGoodDataParser.Models
{
    internal class FormatTwo
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Currency { get; set; }
        public string CustodianCode { get; set; }
        public bool MyAccount { get; set; }
        public int AccountType { get; set; }
        public CurrencyType DollarType { get; set; }

    }
}