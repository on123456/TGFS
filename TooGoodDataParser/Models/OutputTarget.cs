using System;
using System.Collections.Generic;
using System.Text;
using TooGoodDataParser.Utilities;

namespace TooGoodDataParser.Models
{
    internal class OutputTarget
    {
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime OpenedDate { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public bool MyAccount { get; set; }
        public string AccountType { get; set; }
        public DateTime DateCreated { get; set; }
        public string DollarType { get; set; }
    }
}