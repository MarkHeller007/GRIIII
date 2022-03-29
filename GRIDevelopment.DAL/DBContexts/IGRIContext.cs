using GRIDevelopment.DAL.DomainModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GRIDevelopment.DAL.DBContexts
{
    public interface IGRIContext
    {
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Customer> Customers { get; set; }
    }
}
