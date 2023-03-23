using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SecondProject.Models;
using System.Diagnostics;
using System.IO;

namespace SecondProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _iwebhost;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment iwebhost)
        {
            _logger = logger;
            _iwebhost = iwebhost;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Upload()
        {
            return View();
        }

        // Adding image to your view
        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            String finalName = "";
            try
            {
                var path = Path.Combine(_iwebhost.WebRootPath, "FileUploads");
                string ext = Path.GetExtension(file.FileName);

                string Newname = Guid.NewGuid().ToString().Substring(1, 10);
                finalName = Newname + file.FileName;

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                using (var fileStream = System.IO.File.Create(Path.Combine(path, finalName)))
                {
                    file.CopyTo(fileStream);
                }
                return View();
            }
            catch
            {
                return View();
            }
            
        }

        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}