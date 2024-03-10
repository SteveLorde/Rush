using Microsoft.AspNetCore.Mvc;

namespace Rush.Services;

public interface IFileServing
{
    public Task<FileStreamResult> ReturnFile(Guid itemid);
}