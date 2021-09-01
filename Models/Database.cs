using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayApp.Models
{
    public class Database
    {
        private static Dictionary<string, InvitationModel> _list;

        static Database()
        {
            _list = new Dictionary<string, InvitationModel>();
            _list.Add("Furkan", new InvitationModel
            {
                Name = "Furkan",
                Posta = "furkan@gmail.com",
                ParticipationStatus = true
            }); 
            _list.Add("Aleyna", new InvitationModel
            {
                Name = "Aleyna",
                Posta = "aleyna@gmail.com",
                ParticipationStatus = true
            });
            _list.Add("Fatih", new InvitationModel
            {
                Name = "Fatih",
                Posta = "fatih@gmail.com",
                ParticipationStatus = false
            });
        }

        public static void Add(InvitationModel model)
        {
            string key = model.Name.ToLower();
            if(_list.ContainsKey(key))
            {
                _list[key] = model;
            }
            else
            {
                _list.Add(key, model);
            }
        }

        public static IEnumerable<InvitationModel> List
        {
            get { return _list.Values; }
        }
    }
}
