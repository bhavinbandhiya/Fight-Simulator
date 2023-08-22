using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{ID=1, Name = "Sam"} 
        };   
        
        [HttpGet("GetAll")]
        public ActionResult <List<Character>> Get()
        {
            return Ok(characters);
        }

         [HttpGet("{id}}")]
        public ActionResult <List<Character>> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.ID == id));
        }
    }
}