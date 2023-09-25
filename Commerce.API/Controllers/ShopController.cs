using Commerce.Application;
using Commerce.Application.Dtos;
using Commerce.Domain.Contracts;
using Commerce.Domain.Links;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Commerce.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {

        // method 1 -> get shop by id
        // method 2 -> get shops
        // methos 3 -> generate page links
        // methos 4 -> add shop
        // method 5 -> update shop
        // method 6 -> delete shop

        private readonly IShopService _shopService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ShopController( IWebHostEnvironment hostEnvironment)
        {
            _webHostEnvironment = hostEnvironment;
        }

        private void UploadedFile(IFormFile image, string filename)
        {
            if (image != null && !string.IsNullOrWhiteSpace(filename))
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string filePath = Path.Combine(uploadsFolder, filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
            }
        }

        private string GenerateFileName(IFormFile image)
        {
            string uniqueFileName = null;
            if (image != null)
            {
                uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            }
            return uniqueFileName;
        }
    }
}
