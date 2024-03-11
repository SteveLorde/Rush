namespace Rush.Data.Models;

public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Filesname { get; set; }
    public string imagecover { get; set; }
    public DateOnly LastUpdated { get; set; }
}