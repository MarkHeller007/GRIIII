using AutoMapper;

using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRIDevelopment.Mpper
{
    public class DomainCustomerMapper
    {
        private readonly IMapper _mapper;
        public DomainCustomerMapper(IMapper imapper)
        {
            _mapper = imapper;
        }
        public Customer ToCustomerDomain(CustomerDTO customer)
        {
            return _mapper.Map<CustomerDTO, Customer>(customer);
        }
        public List<CustomerDTO> ToCustomerDTOs(List<Customer> customers)
        {
            return _mapper.Map<List<Customer>, List<CustomerDTO>>(customers);
        }
        public CustomerDTO ToCustomerDTO(Customer customer)
        {
            return _mapper.Map<Customer, CustomerDTO>(customer);
        }
    }
}
