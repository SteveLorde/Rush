using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rush.Data.Models;
using Rush.Services;

namespace Rush.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IFileServing _fileservice;
    public List<Item> items;

    public IndexModel(ILogger<IndexModel> logger, IFileServing fileserving)
    {
        _logger = logger;
        _fileservice = fileserving;
    }

    public void OnGet()
    {
        
    }

    public void GetFile(Guid itemid)
    {
        
    }
    
    
}