using GamesForum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamesForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // return View();
            return RedirectToAction("Index", "Articles", new { area = "" });
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Search(string query)
        {
            // 模擬從資料庫取得的搜尋結果
            var sampleData = new List<SearchResultViewModel>
    {
            new SearchResultViewModel { ImageUrl = "/images/sample1.jpg", Detail = "Sample Item 1" },
            new SearchResultViewModel { ImageUrl = "/images/sample2.jpg", Detail = "Sample Item 2" },
            new SearchResultViewModel { ImageUrl = "/images/sample3.jpg", Detail = "Sample Item 3" },
    };

            // 如果有搜尋條件，篩選資料
            var results = string.IsNullOrEmpty(query)
                ? sampleData
                : sampleData.Where(item => item.Detail.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

            return View(results);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
