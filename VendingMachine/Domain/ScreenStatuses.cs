using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Domain {
    public static class ScreenStatuses {
        public static string InsertCoins { get { return "INSERT COINS"; } }
        public static string SoldOut { get { return "SOLD OUT"; } }
        public static string ExactChangeOnly { get { return "EXACT CHANGE ONLY"; } }
        public static string ThankYou { get { return "THANK YOU"; } }
        public static string Price { get { return "PRICE "; } }
        public static string Vending { get { return "VENDING "; } }
        public static string Credit { get { return "$ "; } }
    }
}