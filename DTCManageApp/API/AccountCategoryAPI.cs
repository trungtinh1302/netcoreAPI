using DTCManageApp.Domain;
using DTCManageApp.Domain.AccountCategoryAggregate;
using DTCManageApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTCManageApp.API
{
    [Produces("application/json")]
    [Route("api/accountcategory")]
    public class AccountCategoryAPI : ControllerBase
    {
        //private DBContext db;
        private readonly IUnitOfWork _unitOfWork;

        public AccountCategoryAPI(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get([FromRoute] int id)
        {
            var accountCat = await _unitOfWork.AccountCategoryRepository.Get(id);
            return Ok(accountCat);
        }

        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            var accountCats = await _unitOfWork.AccountCategoryRepository.GetAll();
            return Ok(accountCats);
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] AccountCategory itemRequest)
        {
            itemRequest.CreatedTime = DateTime.UtcNow;
            var createStatus = await _unitOfWork.AccountCategoryRepository.Create(itemRequest);
            await _unitOfWork.Complete();
            return Ok(createStatus);
        }

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update([FromRoute] int id, [FromBody] AccountCategory itemRequest)
        //{
        //    if (itemRequest.ID != id)
        //    {
        //        return BadRequest();
        //    }

        //    if (!db.AccountCategories.Any(c => c.ID == id))
        //    {
        //        return NotFound();
        //    }

        //    db.Entry(itemRequest).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //        return Ok("OK");
        //    }
        //    catch (Exception)
        //    {
        //        return Forbid();
        //    }
        //}
    }
}
