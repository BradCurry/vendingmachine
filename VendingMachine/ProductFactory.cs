using VendingMachine.Domain;

namespace VendingMachine {
    public class ProductFactory {
        public Product GetProduct(Products product, string location, int priceInCents) {
            if (product == Products.Cola) return new Product(name: "COLA", location: location, priceInCents: 1.00);
            if (product == Products.Chips) return new Product(name: "CHIPS", location: location, priceInCents: 0.50);

            return new Product(name: "CANDY", location: location, priceInCents: 0.65);
        }
    }
}