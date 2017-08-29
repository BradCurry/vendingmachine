using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using VendingMachine.Domain;

namespace VendingMachine.Tests {
    [TestClass]
    public class VendingEngineTests {
        [TestMethod]
        public void GivenCoinInserted_WhenDenominationIsPenny_CoinIsRejected() {
            var coins = new CoinFactory();
            var penny = coins.GetCoin(Coins.Penny);

            var availableCoins = new List<Coin>();
            var availableProducts = new List<Product>();

            var vendingMachine = new VendingEngine(availableCoins, availableProducts);
            vendingMachine.InsertCoin(penny);
            var status = vendingMachine.Screen.Display;

            Assert.AreEqual("INSERT COINS", status);
            Assert.AreEqual(0, vendingMachine.CurrentPurchase.CreditInCents);
            Assert.IsTrue(!vendingMachine.AvailableChange.Any());
            Assert.IsTrue(vendingMachine.CoinReturn.Change.Count() == 1);
        }

        [TestMethod]
        public void GivenCoinInserted_WhenDenominationIsQuarter_CoinIsAddedToPurchaseCredit() {
            var coins = new CoinFactory();
            var quarter = coins.GetCoin(Coins.Quarter);

            var availableCoins = new List<Coin>();
            var availableProducts = new List<Product>();

            var vendingMachine = new VendingEngine(availableCoins, availableProducts);
            vendingMachine.InsertCoin(quarter);
            var status = vendingMachine.Screen.Display;

            Assert.AreEqual("$ 0.25", status);
            Assert.AreEqual(0.25, vendingMachine.CurrentPurchase.CreditInCents);
            Assert.IsTrue(vendingMachine.AvailableChange.Count() == 1);
            Assert.IsTrue(!vendingMachine.CoinReturn.Change.Any());
        }

        [TestMethod]
        public void GivenCoinInserted_WhenDenominationIsDime_CoinIsAddedToPurchaseCredit() {
            var coins = new CoinFactory();
            var dime = coins.GetCoin(Coins.Dime);

            var availableCoins = new List<Coin>();
            var availableProducts = new List<Product>();

            var vendingMachine = new VendingEngine(availableCoins, availableProducts);
            vendingMachine.InsertCoin(dime);
            var status = vendingMachine.Screen.Display;

            Assert.AreEqual("$ 0.10", status);
            Assert.AreEqual(0.10, vendingMachine.CurrentPurchase.CreditInCents);
            Assert.IsTrue(vendingMachine.AvailableChange.Count() == 1);
            Assert.IsTrue(!vendingMachine.CoinReturn.Change.Any());
        }

        [TestMethod]
        public void GivenCoinInserted_WhenDenominationIsNickel_CoinIsAddedToPurchaseCredit() {
            var coins = new CoinFactory();
            var nickel = coins.GetCoin(Coins.Nickel);

            var availableCoins = new List<Coin>();
            var availableProducts = new List<Product>();

            var vendingMachine = new VendingEngine(availableCoins, availableProducts);
            vendingMachine.InsertCoin(nickel);
            var status = vendingMachine.Screen.Display;

            Assert.AreEqual("$ 0.05", status);
            Assert.AreEqual(0.05, vendingMachine.CurrentPurchase.CreditInCents);
            Assert.IsTrue(vendingMachine.AvailableChange.Count() == 1);
            Assert.IsTrue(!vendingMachine.CoinReturn.Change.Any());
        }

        [TestMethod]
        public void GivenExactChangeInserted_WhenChipsProductIsSelected_ChipsAreDespensedAndNoChangeIsReturned() {



        }

        [TestMethod]
        public void GivenExactChangeInserted_WhenColaProductIsSelected_ColaIsDespensedAndNoChangeIsReturned() {



        }

        [TestMethod]
        public void GivenExactChangeInserted_WhenCandyProductIsSelected_CandyIsDespensedAndNoChangeIsReturned() {



        }

        [TestMethod]
        public void GivenMoreChangeThanRequiredIsInserted_WhenChipsProductIsSelected_ChipsAreDespensedAndProperChangeIsReturned() {



        }

        [TestMethod]
        public void GivenMoreChangeThanRequiredIsInserted_WhenColaProductIsSelected_ColaIsDespensedAndProperChangeIsReturned() {



        }

        [TestMethod]
        public void GivenMoreChangeThanRequiredIsInserted_WhenCandyProductIsSelected_CandyIsDespensedAndProperChangeIsReturned() {



        }

        [TestMethod]
        public void GivenAvailableChangeIsEmpty_WhenCustomerChecksScreen_ExactChangeOnlyIsDisplayed() {



        }

    }
}