using INDOVO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INDOVO.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public static EventModel[] eventModel = {
            new EventModel { Description = "Test Description", EventID = Guid.NewGuid(), ImageURL = "https://placeimg.com/250/250/any", Name = "Test Name" },
                    new EventModel { Description = "Event1", EventID = Guid.NewGuid(), ImageURL = "https://placeimg.com/250/250/any", Name = "Name1" },
                            new EventModel { Description = "Event2", EventID = Guid.NewGuid(), ImageURL = "https://placeimg.com/250/250/any", Name = "Name2" }


        };
        public static EventDetails[] eventDetails = {
            new EventDetails{Name="Event_Detail_1", Event_Start=DateTime.Now,Users=new string[]{"Yeah1","Yeah1","Yeah1"},Description="Event_Detail_1",ImageURL="https://placeimg.com/250/250/any", EventID=eventModel[0].EventID},
            new EventDetails{Name="Event_Detail_2", Event_Start=DateTime.Now,Users=new string[]{"Yeah2","Yeah2","Yeah2"},Description="Event_Detail_2",ImageURL="https://placeimg.com/250/250/any",EventID=eventModel[1].EventID},
                       new EventDetails{Name="Event_Detail_3", Event_Start=DateTime.Now,Users=new string[]{"Yeah3","Yeah3","Yeah3"},Description="Event_Detail_3",ImageURL="https://placeimg.com/250/250/any",EventID=eventModel[2].EventID}
        };
        public ActionResult Index()
        {

            return View(eventModel);
        }
        public ActionResult Event(Guid id)
        {
            return View(eventDetails.Where(e => e.EventID == id).First());
        }
    }
}