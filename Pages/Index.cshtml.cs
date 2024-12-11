using Microsoft.AspNetCore.Mvc.RazorPages;
using EssayWebsite.Data;
using EssayWebsite.Models;
using System.Collections.Generic;
using System.Linq;
using EssayWebsite;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;




public class IndexModel : PageModel
{
    
    

    public IndexModel()
    {
    }
    
    public List<Essay> Essays { get; set; }
    public List<Tag> Tags { get; set; }
    public List<TagItem> TagItems { get; set; }

    public void OnGet()
    {
        AppDbContext _context = new AppDbContext();
        Essays = _context.Essays.OrderByDescending(e => e.DatePosted).ToList();
        Tags = _context.Tags.OrderByDescending(e => e.Id).ToList();
        TagItems = _context.EssayTags.OrderBy(i => i.id).ToList();
    }

 
}