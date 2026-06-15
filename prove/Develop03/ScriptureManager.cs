using System.IO.Enumeration;

public class ScriptureManager {
    List<string> _DW_references = new List<string>();
    List<string> _DW_passages = new List<string>();

    public ScriptureManager(string DW_fileName) {
        try {
            string[] DW_lines = System.IO.File.ReadAllLines(DW_fileName);
            int DW_refLine = 0;
            string DW_passage = "";
            for (int i = 0; i < DW_lines.Length; i++) {
                if (DW_lines[i] == "") {
                    _DW_references.Add(DW_lines[DW_refLine]);
                    _DW_passages.Add(DW_passage);
                    DW_passage = "";
                    DW_refLine = i + 1;
                } else if (i != DW_refLine) {
                    DW_passage += " " + DW_lines[i];
                }
            }
        } catch {
            Console.WriteLine("Could not find the specified file!");
        }
    }

    public List<string> GetReferences() {
        return _DW_references;
    }
    
    public bool CheckReference(string DW_reference) {
        return _DW_references.IndexOf(DW_reference) > -1;
    }

    public string GetScripture(string DW_reference) {
        return _DW_passages[_DW_references.IndexOf(DW_reference)];
    }
}