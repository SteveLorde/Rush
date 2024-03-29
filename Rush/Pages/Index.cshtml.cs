using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rush.Data.Models;
using Rush.Services;

namespace Rush.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IFileServing _fileservice;
    public List<Item> Items = new List<Item>();
    private readonly IRepo _repo;

    public IndexModel(ILogger<IndexModel> logger, IFileServing fileserving, IRepo repo)
    {
        _logger = logger;
        _fileservice = fileserving;
        _repo = repo;
    }

    public async void OnGet()
    {
        Items = await _repo.GetItems();
    }
    
    
    public async Task<FileStreamResult> OnGetDownloadItem(string itemid)
    {
        Guid itemidGuid = Guid.Parse(itemid);
        return await _fileservice.ReturnFile(itemidGuid);
    }
    
    
}