using DividasPagamentos.Application.Interfaces;
using DividasPagamentos.Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DividasPagamentos.API.Controllers
{
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        [Route("/pessoa/{id}")]
        public IActionResult GetPessoa(int id) 
        {
            var pessoa = _pessoaService.GetPessoa(id);

            if(pessoa == null)
            {
                return BadRequest("Pessoa não encontrada!");
            }

            return Ok(pessoa);
        }

        [HttpPost]
        [Route("/pessoa")]
        public IActionResult CreatePessoa([FromBody] PessoaDTO pessoaDTO)
        {
            var pessoa = _pessoaService.CreatePessoa(pessoaDTO);

            if(pessoa == null)
            {
                return BadRequest("Usuário não criado...");
            }

            return Ok(pessoa);
        }

        [HttpGet]
        [Route("/pessoas")]
        public IActionResult GetPessoas()
        {
            var pessoas = _pessoaService.GetPessoas();

            if(pessoas == null)
            {
                return BadRequest("Nenhuma pessoa encontrada!");
            }

            return Ok(pessoas);
        }
    }
}
