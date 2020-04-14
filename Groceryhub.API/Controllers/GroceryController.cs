using System;
using System.Collections.Generic;
using Groceryhub.Application.Abstracts;
using Groceryhub.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Groceryhub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroceryController : ControllerBase
    {
        private readonly IGroceryAppService _groceryAppService;

        public GroceryController(IGroceryAppService groceryAppService)
        {
            _groceryAppService = groceryAppService;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody]Grocery grocery)
        {
            _groceryAppService.Register(grocery);
            return Ok();
        }
        
        [HttpGet("{name}")]
        public ActionResult<IReadOnlyCollection<Grocery>> Get(string name)
        {
            return Ok(_groceryAppService.Search(name));
        }
    }
}