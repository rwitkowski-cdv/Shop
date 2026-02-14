using Microsoft.AspNetCore.Components.Forms;
using Shop.Models;

namespace Shop.Repository.IRepository
{
    public interface IImageRepository
    {
        Task Delete(string directoryPath, string imgUrl);

        Task<string> AddToRoot(InputFileChangeEventArgs e, string directoryPath);
    }
}
