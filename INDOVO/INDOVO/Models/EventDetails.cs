using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INDOVO.Models
{
    public class EventDetails
    {
        public Guid EventID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        public DateTime Event_Start { get; set; }

        public string[] Users { get; set; }
    }
}