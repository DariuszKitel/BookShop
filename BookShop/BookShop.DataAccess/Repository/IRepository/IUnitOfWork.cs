using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        ICoverTypeRepository CoverType { get; }
        IApplicationUserRepository ApplicationUser { get; }
        ISP_Call SP_Call { get; }

        void Save();
    }
}
