using VendingMachine.Domain;

namespace VendingMachine {
    public class CoinFactory {
        public Coin GetCoin(Coins coin) {

            if (coin == Coins.Quarter) return new Coin(mass: 5.670, diameter: 24.26, thickness: 1.75);
            if(coin == Coins.Dime) return new Coin(mass: 2.268, diameter: 17.91, thickness: 1.35);
            if (coin == Coins.Nickel) return new Coin(mass: 5.000, diameter: 21.21, thickness: 1.95);

            return new Coin(mass: 2.5, diameter: 19, thickness: 1.52); // Penny
        }
    }
}