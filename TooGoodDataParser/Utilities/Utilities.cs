using System;
using System.Collections.Generic;
using System.Text;

namespace TooGoodDataParser.Utilities
{
    public static class Utilities
    {
        public static string GetCurrency(this CurrencyType inputCurrency)
        {
            switch(inputCurrency)
            {
                case CurrencyType.CD:
                case CurrencyType.C:
                {
                        return "CAD";
                }
                case CurrencyType.UD:
                case CurrencyType.U:
                    {
                        return "USD";
                    }
                default:
                    return "ERROR";
            }
        }

        public static string GetAccountType(this int inputAccountType)
        {
            return Enum.GetName(typeof(AccountType), inputAccountType);
        }
    }

    public enum CurrencyType
    {
        CD,
        UD,
        C,
        U
    }

    public enum AccountType
    {
        Trading = 1,
        RRSP = 2,
        RESP = 3,
        Fund = 4
    };
}
