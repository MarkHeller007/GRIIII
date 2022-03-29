using AutoMapper;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDevelopment.Mpper
{
    public class DomainProDTOMapper
    {
        private readonly IMapper _mapper;
        public DomainProDTOMapper(IMapper imapper)
        {
            _mapper = imapper;
        }

        public Product ToProductDomain(ProductDTO product)
        {
            return _mapper.Map<ProductDTO, Product>(product);
        }

        public List<ProductDTO> ToProductDTOs(List<Product> products)
        {
            return _mapper.Map<List<Product>, List<ProductDTO>> (products);
        }

        public ProductDTO ToProductDTO(Product product)
        {
            return _mapper.Map<Product, ProductDTO>(product);
        }
    }
}
