using System.Collections.Generic;
using VendingMachine.Domain;

namespace VendingMachine {
    public class DenominationFactory {
        public Denomination GetDenomination(Denominations denomination) {
            if (denomination == Denominations.Quarter) return new Denomination(mass: 5.670, diameter: 24.26, thickness: 1.75, valueInCents: 0.25);
            if (denomination == Denominations.Dime) return new Denomination(mass: 2.268, diameter: 17.91, thickness: 1.35, valueInCents: 0.10);
            if (denomination == Denominations.Nickel) return new Denomination(mass: 5.000, diameter: 21.21, thickness: 1.95, valueInCents: 0.05);

            return new Denomination(mass: 2.5, diameter: 19, thickness: 1.52, valueInCents: 0.01); // Penny (everything is a hammer uh I mean Penny)
        }

        public IList<Denomination> GetAcceptedDenominations() {
            var denominations = new List<Denomination>();
            denominations.Add(GetDenomination(Denominations.Quarter));
            denominations.Add(GetDenomination(Denominations.Dime));
            denominations.Add(GetDenomination(Denominations.Nickel));
            return denominations;
        }
    }
}