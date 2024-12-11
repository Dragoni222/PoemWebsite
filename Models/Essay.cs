using System.Runtime.InteropServices.JavaScript;

namespace EssayWebsite.Models;

public class Essay
{

    public Essay(int id, string title, string content, DateTime datePosted, string type)
    {
        Id = id;
        DatePosted = datePosted;
        Title = title;
        Content = content;
        Type = type;
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public DateTime DatePosted { get; set; }
    public string Type { get; set; }
}