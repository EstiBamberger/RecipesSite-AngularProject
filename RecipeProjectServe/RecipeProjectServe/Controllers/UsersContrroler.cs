using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RecipeProjectServe.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeProjectServe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersContrroler : ControllerBase
    {
        public static List<User> usersList = new List<User>(); 

        // GET: api/<UsersContrroler>
        [HttpGet]
        public List<User> Get()
        {
            return usersList;
        }

        // GET api/<UsersContrroler>/5
        [HttpGet("{name}")]
        public User Get(string name)
        {
            return usersList.FirstOrDefault(u=>u.Name==name);
        }

        // POST api/<UsersContrroler>
        [HttpPost]
        public User Post([FromBody] User value)
        {
            User user = new User(value);
            usersList.Add(user);
            return user;
        }

        // PUT api/<UsersContrroler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<UsersContrroler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
