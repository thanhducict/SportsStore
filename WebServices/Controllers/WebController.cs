using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using WebServices.Models;

namespace WebServices.Controllers
{
    [EnableCors(origins: "http://localhost:52574", headers: "*", methods: "*")]
    public class WebController : ApiController
    {
        private readonly ReservationRepository _repo = ReservationRepository.Current;

        //[DisableCors]
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _repo.GetAll();
        }

        public Reservation GetReservation(int id)
        {
            return _repo.Get(id);
        }

        [HttpPost]
        public Reservation CreateReservation(Reservation item)
        {
            return _repo.Add(item);
        }

        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            return _repo.Update(item);
        }

        public void DeleteReservation(int id)
        {
            _repo.Remove(id);
        }
    }
}
