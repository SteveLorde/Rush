using Microsoft.EntityFrameworkCore;
using Rush.Data;
using Rush.Data.Models;

namespace Rush.Services;

class Repo : IRepo
{
    private readonly DataContext _db;
    private readonly IWebHostEnvironment _webhostenv;

    public Repo(IWebHostEnvironment webhostenv,DataContext db)
    {
        _db = db;
        _webhostenv = webhostenv;
    }
    
    public async Task<List<Item>> GetItems()
    {
        return await _db.Items.ToListAsync();
    }

    public async Task<Item> GetItem(Guid itemid)
    {
        return await _db.Items.FirstAsync(item => item.Id == itemid);
    }

    public async Task<bool> GenerateFolders()
    {
        int checkcounter = 0;
        bool checkfolders = true;
        string storagePath = Path.Combine(_webhostenv.ContentRootPath, "Storage");
        var allItems = await _db.Items.ToListAsync();
        foreach (var item in allItems)
        {
            string itemFolderPath = Path.Combine(storagePath, item.Id.ToString());
            Directory.CreateDirectory(itemFolderPath);
        }
        
        //re-run check
        foreach (var item in allItems )
        {
            var folderpath = Path.Combine(storagePath, item.Id.ToString());
            if (!Directory.Exists(folderpath) && checkcounter < 1)
            {
                checkcounter = checkcounter + 1;
                await GenerateFolders();
            }
            else
            {
                checkfolders = false;
            }
        }
        
        return checkfolders;
    }

    public async Task AddItem()
    {
        throw new NotImplementedException();
    }

    public async Task RemoveItem(Guid itemid)
    {
        throw new NotImplementedException();
    }
}