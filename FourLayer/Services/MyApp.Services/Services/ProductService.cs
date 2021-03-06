﻿using MyApp.Domain.Models;
using MyApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace MyApp.Services.Services
{
    public class ProductService: IProductService
    {
        private IGenericRepository _repo;

        public ProductService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<BriefProductDTO> List()
        {
            // Don't do this!
            // var briefProducts = Mapper.Map<List<BriefProductDTO>>(products);

            var briefProducts = _repo.Query<Product>().Project().To<BriefProductDTO>();
            return briefProducts.ToList();
        }


        public FullProductDTO Get(int id)
        {
            var product = _repo.Query<Product>().First(p => p.Id == id);
            return Mapper.Map<FullProductDTO>(product);
        }


        public void Add(FullProductDTO product)
        {
            _repo.Add(Mapper.Map<Product>(product));
            _repo.SaveChanges();
        }


        public void Edit(FullProductDTO product)
        {
            var originalProduct = _repo.Query<Product>().First(p => p.Id == product.Id);
            originalProduct.Name = product.Name;
            originalProduct.Price = product.Price;
            originalProduct.Description = product.Description;
            _repo.SaveChanges();
        }


        public void Delete(int id)
        {
            _repo.Delete<Product>(id);
            _repo.SaveChanges();
        }
    }
}
