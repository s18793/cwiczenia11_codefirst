using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/med")]
    [ApiController]
    public class MedController : ControllerBase
    {
        private readonly MedDbContext _con;


        public MedController(MedDbContext context)
        {
            _con = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok();
        }


    }
}