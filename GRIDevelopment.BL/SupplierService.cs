using GRIDevelopment.BL.Interface;
using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DBContexts;
using GRIDevelopment.DAL.DomainModel;
using GRIDevelopment.Mpper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRIDevelopment.BL
{
    public class SupplierService : ISupplierService
    {
        private readonly GRIContext _context;
        private readonly DomainDTOMapper _mapper;

        public SupplierService(GRIContext context, DomainDTOMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public SupplierDTO GetSupplierById(int id)
        {
            return _mapper.ToSupplierDTO(_context.Suppliers.FirstOrDefault(x => x.Id == id));
        }

        public void AddSupplier(SupplierDTO supplier)
        {
            _context.Suppliers.Add(_mapper.ToSupplierDomain(supplier));
            _context.SaveChanges();
        }

        public void UpdatePost(SupplierDTO supplier)
        {
            var supplierEntity = _context.Suppliers.FirstOrDefault(x => x.Id == supplier.Id);

            if(supplierEntity != null)
            {
                supplierEntity.SupplierName = supplier.SupplierName;
                supplierEntity.SupContact = supplier.SupContact;
                supplierEntity.SupAddress = supplier.SupAddress;
            }
            _context.SaveChanges();
        }

        public List<SupplierDTO> GetAllSuppliers()
        {
            return _mapper.ToSupplierDTOs(_context.Suppliers.ToList());
        }

        public Supplier GetSupplier(int id)
        {
            return _context.Suppliers.FirstOrDefault(p => p.Id == id);
        }

        public void RemovePost(int id)
        {
            _context.Suppliers.Remove(GetSupplier(id));
            _context.SaveChanges();
        }
    }
}
