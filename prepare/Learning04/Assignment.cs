public class Assignment {
    protected string _DW_studentName;
    private string _DW_topic;

    public Assignment(string DW_studentName = "Missing", string DW_topic = "Unknown") {
        _DW_studentName = DW_studentName;
        _DW_topic = DW_topic;
    }

    public string GetSummary() {
        return $"{_DW_studentName} - {_DW_topic}";
    }
}