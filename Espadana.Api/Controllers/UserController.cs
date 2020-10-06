using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Espadana.Service.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Espadana.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IEspadanaService _service;

        public UserController(IEspadanaService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public ActionResult<EspadanaUserDto> GetUsers(Guid id)
        {
            try
            {
                return _service.GetEspadanaUser(id);
            }
            catch (Exception)
            {

                throw new ApplicationException();
            }
            
        }
        [HttpPost]
        public ActionResult CreateUser(EspadanaUserDto user)
        {
            try
            {
                return Ok(_service.CreateEspadanaUser(user));
            }
            catch (Exception)
            {

                throw new ApplicationException();
            }

        }
    }
}
