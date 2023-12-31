﻿using Microsoft.EntityFrameworkCore;
using ProductStore.Core;
using ProductStore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Infrastructure.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyAppDbContext _context;


        public ProductRepository(MyAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products =  await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task Add(Product model)
		{
			await _context.Products.AddAsync(model);
			await Save();
		}


		public async  Task Delete(int id)
        {
           var product = await _context.Products.FindAsync(id);
            if(product != null) 
            { 
            _context.Products.Remove(product);
                await Save();
            }
        }

        public async Task Update(Product model)
        {
            var product = await _context.Products.FindAsync(model.Id);
            if(product != null)
            {
                product.ProductName = model.ProductName;
				product.Description = model.Description;
				product.Color = model.Color;
				product.Category = model.Category;
                product.Price = model.Price;
                _context.Update(product);
                await Save();
            }
        }
        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
