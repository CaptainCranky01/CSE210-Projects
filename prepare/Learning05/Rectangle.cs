public class Rectangle : Shape {
    private double _DW_length;
    private double _DW_width;

    public Rectangle(string DW_color, double DW_length, double DW_width) : base(DW_color) {
        _DW_length = DW_length;
        _DW_width = DW_width;
    }

    public override double GetArea() {
        return _DW_length * _DW_width;
    }
}