using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace vankata_t_e_gey.Controllers
{
	public class VankoController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult VankoLove()
		{
			return View("VankoLove");
		}
	}
}
