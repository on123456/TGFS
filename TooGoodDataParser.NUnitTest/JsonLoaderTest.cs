using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TooGoodDataParser.Models;
using TooGoodDataParser.Utilities;

namespace TooGoodDataParser.NUnitTest
{
    class JsonLoaderTest
    {
        [Test]
        public void FormatOneJsonBuildTest()
        {
            var formatOne = JsonLoader<FormatOne>.buildFromJson();
            Assert.IsNotNull(formatOne);

            Assert.AreEqual(0, formatOne.Identifier);
            Assert.AreEqual("test name", formatOne.Name);
            Assert.AreEqual("test type", formatOne.Type);
            Assert.AreEqual(Convert.ToDateTime("0001-01-01T00:00:00"), formatOne.OpenedDate);
            Assert.AreEqual("some currency", formatOne.Currency);
            Assert.AreEqual("123|ABCCode", formatOne.IdAndAccountCode);
            Assert.AreEqual(true, formatOne.MyAccount);
            Assert.AreEqual(1, formatOne.AccountType);
            Assert.AreEqual(Convert.ToDateTime("0001-01-01T00:00:00"), formatOne.DateCreated);
            Assert.AreEqual(0, (int)formatOne.DollarType);
        }

        [Test]
        public void FormatTwoJsonBuildTest()
        {
            var formatTwo = JsonLoader<FormatTwo>.buildFromJson();
            Assert.IsNotNull(formatTwo);

            Assert.AreEqual("test name 2", formatTwo.Name);
            Assert.AreEqual("test type 2", formatTwo.Type);
            Assert.AreEqual("some currency 2", formatTwo.Currency);
            Assert.AreEqual("abcxyz", formatTwo.CustodianCode);
            Assert.AreEqual(true, formatTwo.MyAccount);
            Assert.AreEqual(2, formatTwo.AccountType);
            Assert.AreEqual(3, (int)formatTwo.DollarType);
        }
    }
}