public class Reference {
    private string _DW_book;
    private int _DW_chapter;
    private List<int> _DW_verses = new List<int>();

    // Takes a reference as a single string and splits it into each element
    public Reference(string DW_reference) {
        string[] elements = DW_reference.Split(" ");
        _DW_book = elements.Length > 2 ? elements[0] + " " + elements[1] : elements[0];
        elements = elements[elements.Length - 1].Split(":");
        _DW_chapter = int.Parse(elements[0]);
        elements = elements[1].Split(",");
        foreach(string element in elements) {
            string[] verses = element.Split("-");
            if (verses.Length > 1) {
                for (int i = int.Parse(verses[0]); i <= int.Parse(verses[1]); i++) {
                    _DW_verses.Add(i);
                }
            } else {
                _DW_verses.Add(int.Parse(element));
            }
        }
    }

    public Reference(string DW_book, int DW_chapter, int[] DW_verses) {
        _DW_book = DW_book;
        _DW_chapter = DW_chapter;
        _DW_verses.AddRange(DW_verses);
    }

    // Joins each element in the reference into a single string to be printed
    public string FormatReference() { // I don't want to spend the time to make the reference span multiple chapters
        string DW_formattedVerses = $"{_DW_verses[0]}";
        bool DW_combine = false;

        // loop through every verse to combine references like (12,13,14,16) into (12-14,16)
        for (int i = 1; i < _DW_verses.Count; i++) {
            if (_DW_verses[i] > _DW_verses[i-1] + 1) {
                if (DW_combine == true) {
                    DW_formattedVerses += "-" + _DW_verses[i-1];
                    DW_combine = false;
                }
                DW_formattedVerses += "," + _DW_verses[i];
            } else {
                DW_combine = true;
            }
        }

        if (DW_combine == true) {
            DW_formattedVerses += "-" + _DW_verses[_DW_verses.Count - 1];
        }

        return $"{_DW_book} {_DW_chapter}:{DW_formattedVerses}";
    }
}