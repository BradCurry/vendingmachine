namespace VendingMachine.Domain {
    public class Denomination {
        public double ValueInCents { get; set; }
        public double Mass { get; }
        public double Diameter { get; }
        public double Thickness { get; }

        public Denomination(double mass, double diameter, double thickness, double valueInCents) {
            Mass = mass;
            Diameter = diameter;
            Thickness = thickness;
            ValueInCents = valueInCents;
        }
    }
}