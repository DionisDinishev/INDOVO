using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace INDOVO.Models
{
    public class EventModel
    {
        public Guid EventID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

    }
}