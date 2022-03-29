using GRIDevelopment.Contract.DTO;
using GRIDevelopment.DAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GRIDevelopment.BL.Interface
{
    public interface ISupplierService
    {
        void AddSupplier(SupplierDTO supplier);

        void UpdatePost(SupplierDTO supplier);

        List<SupplierDTO> GetAllSuppliers();
        SupplierDTO GetSupplierById(int id);
        void RemovePost(int id);
    }
}
