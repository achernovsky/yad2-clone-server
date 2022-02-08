using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yad2_clone_server.Repositories;

namespace yad2_clone_server.Controllers
{
    [Route("realestate/forsale")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private readonly IListingsRepo _repository;

        public ListingsController(IListingsRepo reposotory)
        {
            _repository = reposotory;
        }

        [HttpGet]
        public async Task<ActionResult> GetListings()
        {
            var listings = await _repository.GetListings();
            return Ok(listings);
        }
    }
}
