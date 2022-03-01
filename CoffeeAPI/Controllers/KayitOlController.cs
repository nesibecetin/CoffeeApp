using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using DataAccess;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KayitOlController : ControllerBase
    {
        ICustomerService _customerService;

        public KayitOlController(ICustomerService customerService)
        {
            _customerService = customerService;
          
        }
        [HttpPost("add")]
        public IActionResult Add( Customer customer)
        {
            BaseCustomerManager bb = new StarbucksBusinessManager(new MernisServiceAdapters() , new CustomerRepositoryDal());
            var result = bb.Add(customer);
                if (result!=null)
                {
                    return Ok(result);
                }               
         
            return BadRequest(result);

        }
        [HttpGet("get")]
        public IActionResult Get()
        {
            var result = _customerService.getAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
