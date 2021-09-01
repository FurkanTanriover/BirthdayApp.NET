using BirthdayApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InvitationForm()
        {
            return View();
        }

        [HttpPost] //kullanıcın girdiği bilgi göndere basınca buraya düşecek
        public IActionResult InvitationForm(InvitationModel model)
        {
            if(ModelState.IsValid)
            {
                Database.Add(model);
                return View("Thanks", model);
            }
            return View(model);
        }
        
        public ActionResult Attendees()
        {
            return PartialView(Database.List.Where(i => i.ParticipationStatus == true));
        }
    }
}
