using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INDOVO.Models
{
    public class DB : DbContext
    {
        DbSet<EventModel> Events { get; set; }
        DbSet<EventDetails> EventsDetails { get; set; }
        DbSet<User> Users { get; set; }
    }
}