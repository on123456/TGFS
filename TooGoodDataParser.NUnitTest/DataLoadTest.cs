using NUnit.Framework;
using TooGoodDataParser;
using TooGoodDataParser.Models;
using TooGoodDataParser.NUnitTest;

namespace Tests
{
    public class DataLoadTest : Helper
    {
        [SetUp]
        public void Setup()
        {
            CaseOneTest();
            CaseTwoTest();
        }

        [Test]
        public void CaseOneTest()
        {
            var actual = Program.CaseOne();

            Assert.AreEqual(Newtonsoft.Json.JsonConvert.SerializeObject(formatOneExpectedOutput),
                Newtonsoft.Json.JsonConvert.SerializeObject(actual));
        }

        [Test]
        public void CaseTwoTest()
        {
            var actual = Program.CaseTwo();

            Assert.AreEqual(Newtonsoft.Json.JsonConvert.SerializeObject(formatTwoExpectedOutput),
                Newtonsoft.Json.JsonConvert.SerializeObject(actual));
        }
    }
}