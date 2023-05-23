using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TrabajoFinalC_.Models;
using Newtonsoft.Json;

namespace TrabajoFinalC_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Index()
    // {
    //     return View();
    // }

//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }


public IActionResult Index()
{

    const string apiUrl = "https://rickandmortyapi.com/api/character";
    
    var client = new HttpClient();
    var response = client.GetAsync(apiUrl).Result;
    var content = response.Content.ReadAsStringAsync().Result;
    
    var model = JsonConvert.DeserializeObject<Root>(content);

    return View(model);
}



public IActionResult Index1()
{

    const string apiUrl1 = "https://rickandmortyapi.com/api/location";
    
    var client = new HttpClient();
    var response = client.GetAsync(apiUrl1).Result;
    var content = response.Content.ReadAsStringAsync().Result;
    
    var model1 = JsonConvert.DeserializeObject<Root1>(content);

    return View(model1);
}
}