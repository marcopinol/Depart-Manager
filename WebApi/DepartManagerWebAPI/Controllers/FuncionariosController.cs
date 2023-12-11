using AutoMapper;
using DepartManagerWebAPI.Dto;
using DepartManagerWebAPI.Interfaces;
using DepartManagerWebAPI.Models;
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
        [ProducesResponseType(404)]
        public IActionResult GetEmployes(int departId) 
        {
            if (!_funcionarioRepository.DepartExists(departId))
                return StatusCode(404, "Departamento inexistente");

            var employes = _mapper.Map<List<FuncionarioDto>>(_funcionarioRepository.ListarFuncionarios(departId));

            return Ok(employes);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult CreateEmployes( [FromBody] Funcionario funcionario)
        {
            if (funcionario == null)
                return BadRequest(ModelState);

            if (funcionario.Id != 0)
                funcionario.Id = 0;

            if (!_funcionarioRepository.DepartExists(funcionario.departamentoId))
                return NotFound("Depart inexistente");
                
            var employe = _funcionarioRepository.RegisterFuncionario(funcionario);

            return Ok(employe);
        }

        [HttpDelete("{employeId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult DeleteEmploye(int employeId)
        {
            if (!_funcionarioRepository.FuncionarioExiste(employeId))
                return NotFound("Funcionario inexistente");

            var employe_to_delete = _funcionarioRepository.GetEmploye(employeId);

            _funcionarioRepository.DeleteEmploye(employe_to_delete);

            return Ok("Funcionario removido");
        }
    }
}
