public class Circle : Shape {
    private double _DW_radius;

    public Circle(string DW_color, double DW_radius) : base(DW_color) {
        _DW_radius = DW_radius;
    }

    public override double GetArea() {
        return _DW_radius * _DW_radius * Math.PI;
    }
}