public class Word {
    private string _DW_text;
    private string _DW_punctuation;
    private bool _DW_hidden;

    public Word(string DW_word) {
        _DW_text = DW_word;
    }

    public Word(string DW_word, string DW_punct) {
        _DW_text = DW_word;
        _DW_punctuation = DW_punct;
    }

    public string GetWord() {
        return (_DW_hidden ? new string('_', _DW_text.Length) : _DW_text) + _DW_punctuation;
    }

    public void HideWord() {
        _DW_hidden = true;
    }

    public bool GetHidden() {
        return _DW_hidden;
    }
}