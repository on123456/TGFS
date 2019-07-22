using System;
using System.Collections.Generic;
using System.Text;
using TooGoodDataParser.Models;

namespace TooGoodDataParser.NUnitTest
{
    public class Helper
    {
        internal static OutputTarget formatOneExpectedOutput;
        internal static OutputTarget formatTwoExpectedOutput;
        
        public Helper()
        {
            SetUpFormatOneExpectedOutput();
            SetUpFormatTwoExpectedOutput();
        }
        public static void SetUpFormatOneExpectedOutput()
        {
            formatOneExpectedOutput = new OutputTarget
            {
                AccountCode = "ABCCode",
                Name = "test name",
                Type = "test type",
                OpenedDate = Convert.ToDateTime("0001-01-01T00:00:00"),
                Currency = "some currency",
                Code = "123",
                MyAccount = true,
                AccountType = "Trading",
                DateCreated = Convert.ToDateTime("0001-01-01T00:00:00"),
                DollarType = "CAD"
            };
        }

        public static void SetUpFormatTwoExpectedOutput()
        {
            formatTwoExpectedOutput = new OutputTarget
            {
                AccountCode = "abcxyz",
                Name = "test name 2",
                Type = "test type 2",
                OpenedDate = Convert.ToDateTime("0001-01-01T00:00:00"),
                Currency = "some currency 2",
                Code = null,
                MyAccount = true,
                AccountType = "RRSP",
                DateCreated = Convert.ToDateTime("0001-01-01T00:00:00"),
                DollarType = "USD"
            };
        }
    }
}