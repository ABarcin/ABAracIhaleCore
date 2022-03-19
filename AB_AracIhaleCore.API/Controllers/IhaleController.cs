using AB_AracIhaleCore.DAL.DAL.Abstract;
using AB_AracIhaleCore.DAL.Dtos;
using AB_AracIhaleCore.MODEL.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB_AracIhaleCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IhaleController : ControllerBase
    {
        IIhaleDAL _dal;
        IMapper _mapper;

        public IhaleController(IIhaleDAL dal, IMapper mapper)
        {
            _dal = dal;
            _mapper = mapper;
        }
        [HttpPost("Add")]
        public IActionResult InsertIhale([FromBody] IhaleDTO ihale)
        {
            var value=_dal.InsertIhale(_mapper.Map<Ihale>(ihale));
            if (value>0)
            {
                return StatusCode(201,ihale);
            }
            return BadRequest();
        }
    }
}
