using ExpressoApi.Data;
using ExpressoApi.Models;
using System.Net;
using System.Web.Http;

namespace ExpressoApi.Controllers
{
    public class ReservationsController : ApiController
    {
        private ExpressoDbContext _dbContext = new ExpressoDbContext();

        public IHttpActionResult Post(Reservation reservation)
        {
            if (!ModelState.IsValid)
               return BadRequest(ModelState);

            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();

            return StatusCode(HttpStatusCode.Created);
        }
    }
}
