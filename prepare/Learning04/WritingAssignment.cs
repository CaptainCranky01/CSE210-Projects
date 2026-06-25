public class WritingAssignment : Assignment {
    private string _DW_title;

    public WritingAssignment(string DW_studentName = "Missing", string DW_topic = "Unknown", string DW_title = "Unknown") : base(DW_studentName, DW_topic) {
        _DW_title = DW_title;
    }

    public string GetWritingInformation() {
        return $"{_DW_title} by {_DW_studentName}";
    }
}