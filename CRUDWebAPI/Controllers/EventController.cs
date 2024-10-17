using CalendarLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDWebAPI.Controllers
{
    [RoutePrefix("api/Event")]
    public class EventController : ApiController
    {
        
        CalendarDBEntities OE = new CalendarDBEntities();

        // ../api/Event
        [HttpGet]
        public List<string> Get([FromUri] string date)
        {

            string query = "SELECT * FROM Events WHERE date = @date";

            var events = OE.Events.SqlQuery(query, new SqlParameter("@date", Uri.UnescapeDataString(date)));

            // return just the event names 
            return events.Select(e => e.name).ToList();
        }

        // ../api/Event/add
        [HttpPost]
        [Route("add")]
        public void Post([FromBody] Event e)
        {
            OE.Events.Add(e);
            OE.SaveChanges();
        }
    }
}
