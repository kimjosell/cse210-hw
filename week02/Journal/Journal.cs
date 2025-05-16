using System.IO;
public class Journal {
    public List<EntryText> _entries =  new List<EntryText>();

    public Journal(){}

    public void AddEntry(EntryText newEntry){
        _entries.Add(newEntry);
    }

    public void DisplayAll(){
        foreach(EntryText entry in _entries){
            entry.Display();
        }
    }
    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach (EntryText entry in _entries){
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file){
        string[] lines  = System.IO.File.ReadAllLines(file);

        foreach(string line in lines){
            string[] parts = line.Split("|");
            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            EntryText entry  = new EntryText();
            entry._date = date;
            entry._promptText = promptText;
            entry._entryText = entryText;
            _entries.Add(entry);
        }
    }
}