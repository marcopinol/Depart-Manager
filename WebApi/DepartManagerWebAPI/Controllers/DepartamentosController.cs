using AutoMapper;
using DepartManagerWebAPI.Dto;
using DepartManagerWebAPI.Interfaces;
using DepartManagerWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartManagerWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartamentosController : Controller
    {
        private readonly IDepartamentoRepository _departamentoRepository;
        private readonly IMapper _mapper;

        public DepartamentosController(IDepartamentoRepository departamentoRepository, IMapper mapper)
        {
            _departamentoRepository = departamentoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<DepartamentoDto>))]
        public IActionResult GetDeparts()
        {
            var departs = _mapper.Map<List<DepartamentoDto>>(_departamentoRepository.Listar());

            return Ok(departs);
        }
    }
}
