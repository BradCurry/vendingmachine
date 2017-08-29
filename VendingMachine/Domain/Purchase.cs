using VendingMachine.Domain;

namespace VendingMachine {
    public class Purchase {
        public Product SelectedProduct { get; set; }
        public double CreditInCents { get; set; }
    }
}