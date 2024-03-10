using Microsoft.EntityFrameworkCore;
using Rush.Data;
using Rush.Data.Models;

namespace Rush.Services;

class Repo : IRepo
{
    private readonly DataContext _db;

    public Repo(DataContext db)
    {
        _db = db;
    }
    
    public async Task<List<Item>> GetItems()
    {
        return await _db.Items.ToListAsync();
    }

    public async Task<Item> GetItem(Guid itemid)
    {
        return await _db.Items.FirstAsync(item => item.Id == itemid);
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