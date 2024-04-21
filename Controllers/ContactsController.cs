using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()//Contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Contact contact)//Contacts
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}
