using GRIDevelopment.Contract.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDevelopment.BL.Interface
{
    public interface IProductService
    {
        void AddProduct(ProductDTO product);

        void UpdatePost(ProductDTO product);

        List<ProductDTO> GetAllProducts();
        ProductDTO GetProductById(int id);
        void RemovePost(int id);
    }
}
