using BirthdayApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InvitationController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<InvitationModel> Attendees()
        {
            return Database.List.Where(i => i.ParticipationStatus == true);
        } 
        [HttpGet]
        public IEnumerable<InvitationModel> Disagree()
        {
            return Database.List.Where(i => i.ParticipationStatus == false);
        }

        [HttpPost]
        public void Add(InvitationModel model)
        {
            if(ModelState.IsValid)
            {
                Database.Add(model);
            }
        }
    }
}
