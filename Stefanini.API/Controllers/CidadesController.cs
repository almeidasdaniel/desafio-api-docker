using Microsoft.AspNetCore.Mvc;
using Stefanini.Application.DTO.DTO;
using Stefanini.Application.Interfaces;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Stefanini.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CidadesController : NewControllerBase
    {
        private readonly IApplicationServiceCidade _applicationServiceCidade;

        public CidadesController(IApplicationServiceCidade ApplicationServiceCidade)
        {
            _applicationServiceCidade = ApplicationServiceCidade;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var action = await _applicationServiceCidade.GetAllAsync();
                return Ok(action);
            }
            catch (Exception ex)
            {
                return ExceptionHandling(ex);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var action = await _applicationServiceCidade.GetByIdAsync(id);
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
        [Description("Adiciona nova cidade")]
        public async Task<IActionResult> Post([FromBody] CidadeDTO cidadeDTO)
        {
            try
            {
                var action = await _applicationServiceCidade.AddAsync(cidadeDTO);
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
        [Description("Atualiza cidade")]
        public async Task<IActionResult> Put(int id, [FromBody] CidadeDTO cidadeDTO)
        {
            try
            {
                var action = await _applicationServiceCidade.UpdateAsync(cidadeDTO);
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
                var action = await _applicationServiceCidade.RemoveAsync(id);
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
