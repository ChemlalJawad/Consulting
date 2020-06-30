using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consulting.Core.Models;
using Consulting.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consulting.API.Controllers
{
    [Route("api/consultants")]
    [ApiController]
    public class ConsultantController : ControllerBase
    {
        private readonly IConsultantService _consultantService;

        public ConsultantController(IConsultantService consultantService)
        {
            _consultantService = consultantService;
        }

        [HttpGet]
        public ActionResult<List<Consultant>> GetAll()
        {
            var consultants =  _consultantService.GetAll();

            return Ok(consultants);
        }
       
        [HttpGet("{id}")]
        public ActionResult<Consultant> GetById([FromRoute] int id)
        {
            var consultant =  _consultantService.GetById(id);

            return Ok(consultant);
        }

    }
}
