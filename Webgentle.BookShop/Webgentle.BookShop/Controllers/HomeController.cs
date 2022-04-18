using Microsoft.AspNetCore.Mvc;


namespace Webgentle.BookShop.Controllers
{
    public class HomeController : Controller   // to make it an MVC controller we inherited it with controller class
    {
        public string index() 
        { 
            
            return "i am in home controller";
        }
    }
}
