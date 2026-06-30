public class Shape {
    private string _DW_color;

    public Shape(string DW_color = "") {
        _DW_color = DW_color;
    }

    public virtual double GetArea() {
        return 0;
    }

    public string GetColor() {
        return _DW_color;
    }
}