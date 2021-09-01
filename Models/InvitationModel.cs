using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayApp.Models
{
    public class InvitationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Posta { get; set; }
        [Required]
        public bool ParticipationStatus { get; set; }
    }
}
