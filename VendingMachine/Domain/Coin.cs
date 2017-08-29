namespace VendingMachine.Domain {
    public class Coin {
        public double Mass { get; }
        public double Diameter { get; }
        public double Thickness { get; }

        public Coin(double mass, double diameter, double thickness) {
            Mass = mass;
            Diameter = diameter;
            Thickness = thickness;
        }
    }
}