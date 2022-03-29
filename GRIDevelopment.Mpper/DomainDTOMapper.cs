using AutoMapper;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDevelopment.Mpper
{
    public class DomainDTOMapper
    {
        private readonly IMapper _mapper;
        public DomainDTOMapper(IMapper imapper)
        {
            _mapper = imapper;
        }

        public Supplier ToSupplierDomain(SupplierDTO supplier)
        {
            return _mapper.Map<SupplierDTO, Supplier>(supplier);
        }

        public List<SupplierDTO> ToSupplierDTOs(List<Supplier> suppliers)
        {
            return _mapper.Map<List<Supplier>, List< SupplierDTO>> (suppliers);
        }

        public SupplierDTO ToSupplierDTO(Supplier supplier)
        {
            return _mapper.Map<Supplier, SupplierDTO>(supplier);
        }



    }
}
