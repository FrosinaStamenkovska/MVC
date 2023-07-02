using Microsoft.AspNetCore.Mvc;
using NBA_Teams.Database;

namespace NBA_Teams.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View(NBAdatabase.Teams());
        }

        public IActionResult Details(int id)
        {
            var team = NBAdatabase.Teams().FirstOrDefault(x => x.Id == id);
            return View(team);
        }
    }
}
