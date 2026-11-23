using System.Collections.Generic;

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

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Título: {_title}");
        Console.WriteLine($"Autor: {_author}");
        Console.WriteLine($"Duração: {_length} segundos");
        Console.WriteLine($"Comentários: {GetCommentCount()}");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentInfo());
        }

        Console.WriteLine();
    }
}