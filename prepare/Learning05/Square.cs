public class Square : Shape {
    private double _DW_side;

    public Square(string DW_color, double DW_side) : base(DW_color) {
        _DW_side = DW_side;
    }

    public override double GetArea() {
        return _DW_side * _DW_side;
    }
}