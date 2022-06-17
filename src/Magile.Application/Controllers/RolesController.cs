using Magile.Domain.Entities;
using Magile.Domain.Interfaces;
using Magile.Domain.ViewModels.Role;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;


namespace Magile.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private IRoleService _service;

        public RolesController(IRoleService service) 
            => _service = service;


        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Get(id);
                if (result == null)
                    return NotFound("Registro não encontrado");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.GetAll();
                return Ok(result);

    }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoleInsertViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var entity = new RoleEntity();
                var insertEntity = entity.Insert(model);
                return Ok(await _service.Post(insertEntity));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] RoleUpdateViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var result = await _service.Get(model.Id);
                if (result == null)
                    return NotFound("Registro não encontrado");

                var entity = new RoleEntity();
                var updateEntity = entity.Update(result, model);
                return Ok(await _service.Put(updateEntity));
            } 
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var result = await _service.Get(id);
                if (result == null)
                    return NotFound("Registro não encontrado");

                return Ok(await _service.Delete(id));
            } 
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
            
        }
    }
}
