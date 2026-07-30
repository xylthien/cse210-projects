public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        string[] pieces = text.Split(' ');

        foreach (string piece in pieces)
        {
            _words.Add(new Word(piece));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int hidden = 0;

        while (hidden < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string output = _reference.GetDisplayText() + "/n/n";

        foreach (Word word in _words)
        {
            output += word.GetDisplayText() + " ";
        }

        return output;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}