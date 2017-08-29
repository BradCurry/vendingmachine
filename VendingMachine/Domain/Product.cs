namespace VendingMachine.Domain {
    public class Product {
        public string Name { get; }
        public string Location { get;  }
        public double PriceInCents { get; }

        public Product(string name, string location, double priceInCents) {
            Name = name;
            Location = location;
            PriceInCents = priceInCents;
        }
    }
}