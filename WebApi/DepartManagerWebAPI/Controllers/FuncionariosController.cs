using AutoMapper;
using DepartManagerWebAPI.Dto;
using DepartManagerWebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DepartManagerWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionariosController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IMapper _mapper;

        public FuncionariosController(IFuncionarioRepository funcionarioRepository, IMapper mapper)
        {
            _funcionarioRepository = funcionarioRepository;
            _mapper = mapper;
        }

        [HttpGet("{departId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<FuncionarioDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetEmployes(int departId) 
        {
            if (!_funcionarioRepository.FuncionarioExiste(departId))
                return StatusCode(400, "Departamento sem funcionarios");

            var employes = _mapper.Map<List<FuncionarioDto>>(_funcionarioRepository.ListarFuncionarios(departId));

            return Ok(employes);
        }
    }
}
