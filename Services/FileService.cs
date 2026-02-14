using Microsoft.AspNetCore.Components.Forms;
using Shop.Repository.IRepository;

namespace Shop.Services
{
    public class FileService
    {
        private readonly IImageRepository _imageRepository;

        public FileService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<string> AddImageToRoot(InputFileChangeEventArgs e, string directoryPath)
        {
            return await _imageRepository.AddtoRoot(e, directoryPath);
        }

        public async Task DeleteImage(string directoryPath, string imgUrl)
            {
                await _imageRepository.Delete(directoryPath, imgUrl);
        }
    }
}
