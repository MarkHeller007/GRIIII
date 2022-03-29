using GRIDevelopment.BL.Interface;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DBContexts;
using GRIDevelopment.DAL.DomainModel;
using GRIDevelopment.Mpper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GRIDevelopment.BL
{
    public class ProductService : IProductService
    {
        private readonly GRIContext _context;
        private readonly DomainProDTOMapper _mapper;

        public ProductService(GRIContext context, DomainProDTOMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ProductDTO GetProductById(int id)
        {
            return _mapper.ToProductDTO(_context.Products.FirstOrDefault(x => x.Id == id));
        }

        public void AddProduct(ProductDTO product)
        {
            _context.Products.Add(_mapper.ToProductDomain(product));
            _context.SaveChanges();
        }

        public void UpdatePost(ProductDTO product)
        {
            var productEntity = _context.Products.FirstOrDefault(x => x.Id == product.Id);

            if (productEntity != null)
            {
                productEntity.ProductName = product.ProductName;
                productEntity.ProductDescription = product.ProductDescription;
                productEntity.Application = product.Application;
                productEntity.RimSize = product.RimSize;
                productEntity.TubeSize = product.TubeSize;
                productEntity.Price = product.Price;
            }
            _context.SaveChanges();
        }

        public List<ProductDTO> GetAllProducts()
        {
            return _mapper.ToProductDTOs(_context.Products.ToList());
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public void RemovePost(int id)
        {
            _context.Products.Remove(GetProduct(id));
            _context.SaveChanges();
        }
    }
}
