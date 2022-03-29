using AutoMapper;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDevelopment.Mpper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<SupplierDTO, Supplier>();
            CreateMap<Supplier, SupplierDTO>();

            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();

            CreateMap<CustomerDTO, Customer>();
            CreateMap<Customer, CustomerDTO>();
        }
    }
}
