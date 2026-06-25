public class MathAssignment : Assignment {
    private string _DW_textbookSection;
    private string _DW_problems;

    public MathAssignment(string DW_studentName = "Missing", string DW_topic = "Unknown", string DW_textbookSection = "0.0", string DW_problems = "") : base(DW_studentName, DW_topic) {
        _DW_textbookSection = DW_textbookSection;
        _DW_problems = DW_problems;
    }

    public string GetHomeworkList() {
        return $"Section {_DW_textbookSection} Problems {_DW_problems}";
    }
}