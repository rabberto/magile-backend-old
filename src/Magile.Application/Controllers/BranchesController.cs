//using System;
//using System.Net;
//using System.Threading.Tasks;
//using Magile.Domain.Entities;
//using Magile.Domain.Interfaces;
//using Magile.Domain.ViewModels.Branch;
//using Microsoft.AspNetCore.Mvc;

//namespace Magile.Application.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BranchesController : ControllerBase
//    {
//        private IBranchService _service;
//        public BranchesController(IBranchService service)
//            => _service = service;

//        [HttpGet]
//        [Route("{id}")]
//        public async Task<IActionResult> Get(Guid id)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();

//            try
//            {
//                var result = await _service.Get(id);
//                if (result == null)
//                    return NotFound("Registro não encontrado");

//                return Ok(result);
//            }
//            catch (Exception ex)
//            {
//                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetAll()
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();

//            try
//            {
//                return Ok(await _service.GetAll());
//            }
//            catch (System.Exception ex)
//            {
//                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] BranchInsertViewModel model)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();

//            try
//            {
//                if (model == null)
//                    return BadRequest();

//                var entity = new BranchEntity();
//                var insertEntity = entity.Insert(model);
//                return Ok(await _service.Post(insertEntity));
//            }
//            catch (Exception ex)
//            {
//                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpPut]
//        public async Task<IActionResult> Put([FromBody] BranchUpdateViewModel model)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();
//            try
//            {
//                var result = await _service.Get(model.Id);
//                if (result == null)
//                    BadRequest("Registro não encontrado");
                
//                var entity = new BranchEntity();
//                var updateEntity = entity.Update(result, model);
//                return Ok(await _service.Put(updateEntity));
//            }
//            catch (Exception ex)
//            {
//                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }

//        [HttpDelete]
//        public async Task<IActionResult> Delete(Guid id)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();

//            try
//            {
//                var result = _service.Get(id);
//                if (result == null)
//                    BadRequest("Registro não encontrado");
//                return Ok(await _service.Delete(id));
//            }
//            catch (System.Exception ex)
//            {
//                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
//            }
//        }
//    }
//}
