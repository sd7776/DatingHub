using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingHub.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingHub.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Inject data context into the values controller
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        [AllowAnonymous]
        // GET api/values
        [HttpGet]
        //The IActionResult class allows us to return HTTP requests instead of strings
        //The async keyword makes the code asynchronus which improves performance
        public async Task<IActionResult> GetValues()
        {
            //Initialize a variable to store the values from the database into a list
            var values = await _context.Values.ToListAsync();

            //Return the list along with a HTTP 200 response.
            return Ok(values);
        }

        [AllowAnonymous]
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
