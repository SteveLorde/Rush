using Microsoft.EntityFrameworkCore;
using Rush.Data;
using Rush.Data.Models;

namespace Rush.Services;

class FileServing : IFileServing
{
    private readonly DataContext _db;
    private readonly IWebHostEnvironment _webhostenv;

    public FileServing(DataContext db, IWebHostEnvironment webhostenv)
    {
        _db = db;
        _webhostenv = webhostenv;
    }
    
    public async Task ReturnFile(Guid itemid)
    {
        Item item = await _db.Items.FirstAsync(itemquery => itemquery.Id == itemid);
        string itemPath = Path.Combine(_webhostenv.ContentRootPath, "Storage", item.Id.ToString(), item.Filesname);

        FileStream filestream = new FileStream(itemPath, FileMode.Open, FileAccess.Read);


    }
}