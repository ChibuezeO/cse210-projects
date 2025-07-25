using System;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<int> visibleWordIndices = _words
            .Select((word, index) => new { Word = word, Index = index })
            .Where(x => !x.Word.IsHidden())
            .Select(x => x.Index)
            .ToList();

        int wordsToHide = Math.Min(count, visibleWordIndices.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            if (visibleWordIndices.Count == 0) break;
            int randomIndex = random.Next(visibleWordIndices.Count);
            _words[visibleWordIndices[randomIndex]].Hide();
            visibleWordIndices.RemoveAt(randomIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public string GetDisplayText()
    {
        string displayText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{displayText}";
    }
}