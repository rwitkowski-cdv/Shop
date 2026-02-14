using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;
using Shop.Repository.IRepository;

namespace Shop.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ImageRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> AddToRoot(InputFileChangeEventArgs e, string directoryPath)
        {
            var file = e.File;
            FileInfo fileInfo = new(file.Name);
            var newFileName = $"{Guid.NewGuid()}{fileInfo.Extension}";
            if (Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var path = Path.Combine(directoryPath, newFileName);
            
            await using FileStream stream = new (path, FileMode.Create);
            await file.OpenReadStream(file.Size).CopyToAsync(stream);
            var imgUrl = $"/images/product/{newFileName}";
            return imgUrl;
        }

        public async Task Delete(string directoryPath, string imgUrl)
        {
            var fileToDelete = imgUrl.Split('/').Reverse().First();

            if (fileToDelete == null)
                return;
            var filePathToDelete = Path.Combine(directoryPath, fileToDelete);

            if (!File.Exists(filePathToDelete))
                return;
                        
            File.Delete(filePathToDelete);
            return;
        }
    }
}
