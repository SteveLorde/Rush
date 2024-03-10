using Rush.Data.Models;

namespace Rush.Services;

public interface IRepo
{
    public Task<List<Item>> GetItems();
    public Task<Item> GetItem(Guid itemid);
    public Task AddItem();
    public Task RemoveItem(Guid itemid);
}