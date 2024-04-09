using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet("all")]
        public List<People> GetPeople() => Repository.People;
    }

    public class Repository
    {
        public static List<People> People = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Foo",
                Birthdate = new DateTime(2003, 05, 20),
            },
            new People()
            {
                Id = 2,
                Name = "Carlos",
                Birthdate = new DateTime(2001, 05, 20),
            },
            new People()
            {
                Id = 3,
                Name = "Fernando",
                Birthdate = new DateTime(2000, 05, 20),
            },
            new People()
            {
                Id = 4,
                Name = "Isabel",
                Birthdate = new DateTime(1993, 05, 20),
            },
        };
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
