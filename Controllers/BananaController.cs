using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SimpleMVC.Controllers;

public class BananaController : Controller
{
    //
    // GET: /Banana/
    public IActionResult Index(string name, int eatenBananas=1)
    {
        return View();
    }

    //
    // GET: /Banana/Welcome/
    public string Welcome()
    {
        return "And not forget to drink water";
    }
}