namespace EssayWebsite.Models;

public class TagItem
{
    public int id { get; set; }
    public int EssayID { get; set; }
    public int TagID { get; set; }

    public TagItem(int Id, int essayId, int tagId)
    {
        id = Id;
        EssayID = essayId;
        TagID = tagId;
    }
}