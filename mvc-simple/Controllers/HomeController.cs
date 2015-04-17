using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
	[Route("[controller]")]
	public class HomeController : Controller
	{
		[Route("[action]")]
		public IActionResult Index()
		{
			return View(User());
		}
			
        public User User()
        {
            User user = new User()
            {
                Name = "Yohann Martel",
                Address = "Montreal"
            };

            return user;
        }
    }
}