using System;
using System.Collections.Generic;
using System.Linq;
using VendingMachine.Domain;

namespace VendingMachine {
    public class VendingEngine {
        public Screen Screen { get; private set; }
        public IList<Product> AvailableProducts { get; private set; }
        public IList<Coin> AvailableChange { get; private set; }
        public Purchase CurrentPurchase { get; private set; }
        public CoinReturn CoinReturn { get; private set; }

        public VendingEngine(IList<Coin> availableCoins, IList<Product> availableProducts) {
            AvailableChange = availableCoins;
            AvailableProducts = availableProducts;
            Screen = new Screen { Display = ScreenStatuses.InsertCoins };
            CoinReturn = new CoinReturn();
        }

        public void InsertCoin(Coin coin) {
            if(CurrentPurchase == null) CurrentPurchase = new Purchase { CreditInCents = 0 };
            var denomination = DetermineDenomination(coin);

            if (denomination == 0) {
                CoinReturn.ReturnCoin(coin);
                return;
            }

            CurrentPurchase.CreditInCents += denomination;
            AvailableChange.Add(coin);
            Screen.Display = ScreenStatuses.Credit + CurrentPurchase.CreditInCents.ToString("0.00");
        }

        public void SelectProduct(string location) {

        }

        private double DetermineDenomination(Coin coin) {
            var denominationFactory = new DenominationFactory();
            var availableDenominations = denominationFactory.GetAcceptedDenominations();

            var denomination = availableDenominations.SingleOrDefault(d => d.IsEqualTo(coin));
            if (denomination == null) return 0;
            return denomination.ValueInCents; 
        }
    }
}
