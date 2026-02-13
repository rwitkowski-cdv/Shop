using Microsoft.AspNetCore.Components.Forms;
using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface IImageRepository
    {
        Task Delete(string directoryPath, string imgUrl);

        Task<string> AddtoRoot(InputFileChangeEventArgs e, string directoryPath);
    }
}
