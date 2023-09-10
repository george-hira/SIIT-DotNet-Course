using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly List<Cat> cats;


        public CatsController()
        {
            List<Cat> myCatsList = new List<Cat>();

            var cat1 = new Cat()
            {
                EyeColor = "black",
                Id = 1,
                Name = "Maronica"
            };

            var cat2 = new Cat()
            {
                EyeColor = "green",
                Id = 7,
                Name = "Lillith"
            };
            myCatsList.Add(cat1);
            myCatsList.Add(cat2);
            cats = myCatsList;


        }
        // GET: api/<CatsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CatsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $" AM primit id-ul {id}";
        }

        // POST api/<CatsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CatsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
