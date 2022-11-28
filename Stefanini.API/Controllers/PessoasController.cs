using Microsoft.AspNetCore.Mvc;
using Stefanini.Application.DTO.DTO;
using Stefanini.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace Stefanini.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoasController : NewControllerBase
    {
        private readonly IApplicationServicePessoa _applicationServicePessoa;

        public PessoasController(IApplicationServicePessoa applicationServicePessoa)
        {
            _applicationServicePessoa = applicationServicePessoa;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var action = await _applicationServicePessoa.GetAllAsync();
                return Ok(action);
            }
            catch (Exception ex)
            {
                return ExceptionHandling(ex);
            }
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var action = await _applicationServicePessoa.GetByIdAsync(id);
                return Ok(action);
            }
            catch (ArgumentException ex)
            {
                return ArgumentExceptionHandling(ex);
            }
            catch (Exception ex)
            {
                return ExceptionHandling(ex);
            }
        }

        // POST api/values
        [HttpPost]        
        public async Task<IActionResult> Post([FromBody] PessoaDTO pessoaDTO)
        {
            try
            {
                var action = await _applicationServicePessoa.AddAsync(pessoaDTO);
                return Ok(action);
            }
            catch (ArgumentException ex)
            {
                return ArgumentExceptionHandling(ex);
            }
            catch (Exception ex)
            {
                return ExceptionHandling(ex);
            }
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Put(int id, PessoaDTO pessoaDTO)
        {
            try
            {
                var action = await _applicationServicePessoa.UpdateAsync(pessoaDTO);
                return Ok(action);
            }
            catch (ArgumentException ex)
            {
                return ArgumentExceptionHandling(ex);
            }
            catch (Exception ex)
            {
                return ExceptionHandling(ex);
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var action = await _applicationServicePessoa.RemoveAsync(id);
                return Ok(action);
            }
            catch (ArgumentException ex)
            {
                return ArgumentExceptionHandling(ex);
            }
            catch (Exception ex)
            {
                return ExceptionHandling(ex);
            }
        }
    }
}
