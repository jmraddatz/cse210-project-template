using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumOfComments()
    {
        int count = _comments.Count;

        return count;
    }

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideos()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"By: {_author}");
        Console.WriteLine($"{_length} seconds");
        Console.WriteLine($"Number of Comments: {NumOfComments()}");
        Console.WriteLine("Comments");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComments();
        }
        Console.WriteLine();
    }
}




// Video

// _title:string
// _author:string
// _length:int
// _comments:List<Comment>

// NumOfComments():int
