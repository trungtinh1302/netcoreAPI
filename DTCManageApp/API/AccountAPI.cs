using DTCManageApp.Domain;
using DTCManageApp.Domain.AccountAggregate;
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
    [Route("api/account")]
    public class AccountAPI : ControllerBase
    {
        //private DBContext db;
        private readonly IUnitOfWork _unitOfWork;

        public AccountAPI(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get([FromRoute] int id)
        {
            var accountCat = await _unitOfWork.AccountRepository.Get(id);
            return Ok(accountCat);
        }

        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            var accountCats = await _unitOfWork.AccountRepository.Gets();
            return Ok(accountCats);
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] Account itemRequest)
        {
            itemRequest.CreatedTime = DateTime.UtcNow;
            var createStatus = await _unitOfWork.AccountRepository.Add(itemRequest);
            await _unitOfWork.Complete();
            return Ok(createStatus);
        }
    }
}
