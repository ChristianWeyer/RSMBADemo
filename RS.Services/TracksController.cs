using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using RS.DataAccess;
using RS.Services.DTOs;

namespace RS.Services
{
    public class TracksController : ApiController
    {
        [HttpGet]
        [ActionName("ping")]
        public string Ping()
        {
            return "OK";
        }

        [HttpGet]
        [ActionName("list")]
        public List<TrackDto> ListTracks()
        {
            using (var db = new ChinookContext())
            {
                var result = db.Tracks.Take(20).Select(t => new TrackDto
                {
                    Id = t.TrackId,
                    Name = t.Name
                }).ToList();

                return result;
            }
        }

        [HttpGet]
        [ActionName("single")]
        public TrackDetailsDto GetTrack(int id)
        {
            using (var db = new ChinookContext())
            {
                var result = db.Tracks.FirstOrDefault(t => t.TrackId == id);

                if (result != null)
                {
                    var trackDetails = new TrackDetailsDto
                    {
                        Id = result.TrackId,
                        Name = result.Name,
                        Composer = result.Composer,
                        Duration = result.Milliseconds
                    };

                    return trackDetails;
                }

                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
    }
}