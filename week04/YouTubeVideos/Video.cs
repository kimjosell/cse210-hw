public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenght, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = lenght;
        _comments = comments;
    }

    public string GetDisplayText()
    {
        string finalText = $"{_title} by {_author} ({_length} seconds)\nNumber of Comments: {_comments.Count()}";
        foreach (Comment comment in _comments)
        {
            finalText += $"\n{comment.GetDisplayText()}";
        }

        return finalText;
    }
}