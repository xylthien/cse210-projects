public class Video
{
    public string _title;
    public string _author;
    public int _secLength;

    private List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _secLength = length;
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comment.Count;
    }

    public List<Comment> GetComments()
    {
        return _comment;
    }
}