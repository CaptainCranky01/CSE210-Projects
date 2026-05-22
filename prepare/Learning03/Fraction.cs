public class Fraction {
    private int _DW_top;
    private int _DW_bottom;

    public Fraction() {
        _DW_top = 1;
        _DW_bottom = 1;
    }

    public Fraction(int DW_top) {
        _DW_top = DW_top;
        _DW_bottom = 1;
    }
    
    public Fraction(int DW_top, int DW_bottom) {
        _DW_top = DW_top;
        _DW_bottom = DW_bottom != 0 ? DW_bottom : -1; // Default to -1 to prevent dividing by 0 and still mark them
    }

    public int GetTop() {
        return _DW_top;
    }
    
    public int GetBottom() {
        return _DW_bottom;
    }

    public void SetTop(int DW_top) {
        _DW_top = DW_top;
    }

    public void SetBottom(int DW_bottom) {
        _DW_bottom = DW_bottom != 0 ? DW_bottom : -1; // Default to -1 to prevent dividing by 0 and still mark them
    }

    public string GetFractionString() {
        // If the result is not a fraction then it will return a string representation of a single int
        return _DW_top % _DW_bottom == 0 ? $"{_DW_top / _DW_bottom}" : $"{_DW_top}/{_DW_bottom}";
    }

    public double GetDecimalValue() {
        return (double)_DW_top / _DW_bottom;
    }
}