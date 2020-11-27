using KonyaSonDakikaDepremleri.Models;
using KonyaSonDakikaDepremleri.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KonyaSonDakikaDepremleri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KonyaDepremApiService _konyaDepremApiService;

        public object GlobalConstants { get; private set; }

        public HomeController(ILogger<HomeController> logger, KonyaDepremApiService konyaDepremApiService)
        {
            _konyaDepremApiService = konyaDepremApiService;
            _logger = logger;

        }

        public async Task<IActionResult> Index()
        {
            var response =  await _konyaDepremApiService.GetAllEarthquake();
            return View(response);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
