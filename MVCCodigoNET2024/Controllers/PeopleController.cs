using Microsoft.AspNetCore.Mvc;
using MVCCodigoNET2024.Models;

namespace MVCCodigoNET2024.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {

            List<PersonModel> models = new List<PersonModel>();
            models.Add(new PersonModel
            {
                PersonId = 1,
                FirstName = "Hugo",
                LastName = "Torrico"
            });

            return View(models);
        }
    }
}
