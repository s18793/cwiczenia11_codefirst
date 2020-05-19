using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/med")]
    [ApiController]
    public class MedController : ControllerBase
    {
        // private readonly MedDbContext _con;
        public IMedDbService _imed;

        public MedController(IMedDbService imed)
        {
            _imed = imed;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            var data = _imed.GetDoctors();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult AddDoctor(Doctor doc)
        {
            var data = _imed.AddDoctor(doc);
            return Ok(data);
        }

        [HttpDelete]
        public IActionResult DelecteDoctor(int idDoc)
        {
            var data = _imed.DelecteDoctor(idDoc);
            return Ok(data);
        }
        public IActionResult ModifDoc(Doctor doc)
        {
            var data = _imed.ModifDoc(doc);
            return Ok(data);
        }


    }
}