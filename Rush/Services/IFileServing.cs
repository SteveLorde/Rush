namespace Rush.Services;

public interface IFileServing
{
    public Task ReturnFile(Guid itemid);
}