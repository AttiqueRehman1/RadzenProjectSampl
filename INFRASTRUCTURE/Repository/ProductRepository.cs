using Domain.Interfaces;
using Domains.Models;
using INFRASTRUCTURE.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRASTRUCTURE.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly DatabaseContext _dbcontext;
        public ProductRepository(DatabaseContext databaseContext)
        {
            _dbcontext = databaseContext;
        }

        public async Task<Product> GetProducts()
        {
            try
            {
                return await _dbcontext.Products
                           .Include(p => p.Images)
                           .FirstOrDefaultAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
