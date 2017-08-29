using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Domain {
    public class CoinReturn {
        public IList<Coin> Change { get; private set; }

        public CoinReturn() {
            Change = new List<Coin>();
        }

        public void ReturnCoin(Coin coin) {
            Change.Add(coin);
        }

        public IList<Coin> RetrieveCoins() {
            var coins = Change;
            Change = null;
            return coins;
        }
    }
}