using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SimpleMVC.Controllers;

public class BananaController : Controller
{
    //
    // GET: /Banana/
    public string Index(string name, int eatenBananas=1)
    {
        return HtmlEncoder.Default.Encode($"My name is {name} and I ate {eatenBananas} because bananas Have Potassium. Eat it now you too!");
    }

    //
    // GET: /Banana/Welcome/
    public string Welcome()
    {
        return "And not forget to drink water";
    }
}