public class Scripture
{
    private List<Words> _words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Words>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Words(word));
        }
    }

    public void HideRandomWords(int numberHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        return _reference.GetDisplayText() + "\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}