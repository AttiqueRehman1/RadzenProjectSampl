using Domain.Interfaces;
using Domains.Models;
using INFRASTRUCTURE.DataBaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProduct _iproduct;
        public ProductController(IProduct context)
        {
            _iproduct = context;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var res= await _iproduct.GetProducts(); 
                return Ok(res);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }

    }
}
