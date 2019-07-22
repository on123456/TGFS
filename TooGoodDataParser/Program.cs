using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TooGoodDataParser.Models;
using TooGoodDataParser.Utilities;

[assembly: InternalsVisibleTo("TooGoodDataParser.NUnitTest")]

namespace TooGoodDataParser
{
    class Program
    {
        protected static FormatOne format1;
        static void Main(string[] args)
        {
            CaseOne();
            CaseTwo();

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();
        }

        public static List<OutputTarget> CaseOne()
        {
            //For Case 1
            Console.WriteLine("For test case 1 \n");
            var inputs = JsonLoader<FormatOne>.buildFromJson();

            List<OutputTarget> outputs = new List<OutputTarget>();

            foreach (var input in inputs)
            {
                var dollarType = input.DollarType.GetCurrency();

                string[] numericIdAndAccountCode = input.IdAndAccountCode.Split('|');

                var accountType = input.AccountType.GetAccountType();

                var outputTarget = new OutputTarget();

                PropertyCopier<FormatOne, OutputTarget>.Copy(input, outputTarget);

                outputTarget.AccountType = accountType;
                outputTarget.DollarType = dollarType;
                outputTarget.AccountCode = numericIdAndAccountCode[1];
                outputTarget.Code = numericIdAndAccountCode[0];

                var inputRaw = Newtonsoft.Json.JsonConvert.SerializeObject(input);
                var output = Newtonsoft.Json.JsonConvert.SerializeObject(outputTarget);

                Console.WriteLine("input = {0}", inputRaw);
                Console.WriteLine();
                Console.WriteLine("output = {0}", output);

                outputs.Add(outputTarget);
            }

            return outputs;
        }

        public static List<OutputTarget> CaseTwo()
        {
            // For Case 2
            Console.WriteLine("//////////////////////////\n");
            Console.WriteLine("For test case 2 \n");

            var inputs = JsonLoader<FormatTwo>.buildFromJson();

            List<OutputTarget> outputs = new List<OutputTarget>();

            foreach (var input2 in inputs)
            {
                var dollarType2 = input2.DollarType.GetCurrency();

                var accountType2 = input2.AccountType.GetAccountType();

                var outputTarget2 = new OutputTarget();

                PropertyCopier<FormatTwo, OutputTarget>.Copy(input2, outputTarget2);

                outputTarget2.AccountType = accountType2;
                outputTarget2.DollarType = dollarType2;
                outputTarget2.AccountCode = input2.CustodianCode;

                var inputRaw2 = Newtonsoft.Json.JsonConvert.SerializeObject(input2);
                var output2 = Newtonsoft.Json.JsonConvert.SerializeObject(outputTarget2);

                Console.WriteLine("input = {0}", inputRaw2);
                Console.WriteLine();
                Console.WriteLine("output = {0}", output2);

                outputs.Add(outputTarget2);
            }

            return outputs;
        }
    }
}
