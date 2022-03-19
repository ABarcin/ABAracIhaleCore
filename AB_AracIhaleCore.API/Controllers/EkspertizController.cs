using AB_AracIhaleCore.DAL.Abstract;
using AB_AracIhaleCore.DAL.DAL.Abstract;
using AB_AracIhaleCore.DAL.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    //[Authorize]
    public class EkspertizController : ControllerBase
    {
        IAracTramerDAL _dal;
        IAracTramerDetayDAL _detayDal;
        IMapper _mapper;
        public EkspertizController(IAracTramerDAL dal, IAracTramerDetayDAL detayDal, IMapper mapper)
        {
            _dal = dal;
            _detayDal = detayDal;
            _mapper = mapper;
        }
        [HttpGet("{aracID}")]
        public IActionResult GetEkspertizByID(int aracID)
        {
            var  veri=_dal.AracTramerGetir(aracID);
            return StatusCode(200,veri);
        }
        [HttpGet("~/api/getaractramer/{aracID}")]
        public IActionResult GetAracTramer(int aracID)
        {
            int aracTramerID = _dal.AracTramerGetir(aracID);
            var valueEntities = _detayDal.AracTramerDetayGetir(aracTramerID);

            var valueDTOs = _mapper.Map<List<AracTramerDetayDTO>>(valueEntities);
            return Ok(valueDTOs);
        }

    }
}
