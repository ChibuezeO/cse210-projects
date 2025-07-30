using System;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
    public string CommenterName()
    {
        return _commenterName;
    }

    public string CommentText()
    {
        return _commentText;
    }
}