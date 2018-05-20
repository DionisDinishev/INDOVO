using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INDOVO.Models
{
    public class User
    {
        public Guid UserID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime Joined { get; set; }

        public DateTime DOB { get; set; }
    }
}