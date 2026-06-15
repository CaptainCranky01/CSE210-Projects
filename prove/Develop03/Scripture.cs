public class Scripture {
    private static Scripture _DW_s = null;
    private Reference _DW_reference;
    private List<Word> _DW_passage;
    private int _DW_hiddenWords;
    private Random _DW_rg;

    private Scripture(string DW_reference, string DW_scripture) {
        _DW_reference = new Reference(DW_reference);
        _DW_passage = new List<Word>();
        _DW_hiddenWords = 0;
        _DW_rg = new Random();

        string[] DW_words = DW_scripture.Split(" ");
        foreach (string DW_word in DW_words) {
            if (DW_word.Length > 0) {
                if (char.IsPunctuation(DW_word[DW_word.Length - 1])) {
                    _DW_passage.Add(new Word(DW_word.Substring(0, DW_word.Length - 1), DW_word.Substring(DW_word.Length - 1)));
                } else {
                    _DW_passage.Add(new Word(DW_word));
                }
            }
        }
    }

    public static Scripture getInstance(string DW_reference = null, string DW_scripture = null) {
        if (_DW_s == null) {
            _DW_s = new Scripture(DW_reference, DW_scripture);
        }
        return _DW_s;
    }

    // This method will hide multiple words and build the new display text all in one foreach loop instead of looping several times
    public string HideAndReturn(int DW_hideNum) {
        string DW_returnText = _DW_reference.FormatReference();

        List<int> DW_hideIndexes = new List<int>();
        for (int i = 0; i < DW_hideNum; i++) {
            // add a random word to hide that is still visible
            DW_hideIndexes.Add(_DW_rg.Next(0, _DW_passage.Count - _DW_hiddenWords));
        }

        int DW_currentWord = 0;
        foreach (Word DW_word in _DW_passage) {
            if (!DW_word.GetHidden()) {
                // skip hidden words
                for (int i = 0; i < DW_hideIndexes.Count; i++) {
                    // see if this word is one that should be hidden
                    if (DW_hideIndexes[i] == DW_currentWord) {
                        DW_word.HideWord();
                        DW_hideIndexes.RemoveAt(i);
                        _DW_hiddenWords++;
                        break;
                    }
                }
                DW_currentWord++;
            }

            DW_returnText += " " + DW_word.GetWord();
        }
        return DW_returnText;
    }

    public int GetNumWordsLeft() {
        return _DW_passage.Count - _DW_hiddenWords;
    }
}