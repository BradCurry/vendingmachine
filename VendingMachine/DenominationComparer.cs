using VendingMachine.Domain;

namespace VendingMachine {
    public static class DenominationComparer {
        public static bool IsEqualTo(this Denomination x, Coin y) {
            return x.Mass == y.Mass && x.Thickness == y.Thickness && x.Diameter == y.Diameter;
        }
    }
}