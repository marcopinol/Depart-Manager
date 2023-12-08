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

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult PostDeparts([FromBody] DepartamentoDto newDepart)
        {
            if (newDepart == null)
            {
                return BadRequest(ModelState);
            }

            var depart_to_insert = _mapper.Map<Departamento>(newDepart);

            if (depart_to_insert.Id != 0)
                return BadRequest("Não é permitida a inserção de um valor no campo Id");

            _departamentoRepository.CreateDepart(depart_to_insert);

            return StatusCode(200, depart_to_insert);
        }

        [HttpDelete("{departId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult DeleteDeparts(int departId)
        {
            if (!_departamentoRepository.DepartExist(departId))
                return NotFound("Departamento não encontrado");

            var depart_to_delete = _departamentoRepository.GetDepartamento(departId);

            _departamentoRepository.DeleteDepart(depart_to_delete);

            return Ok();
        }
    }
}
