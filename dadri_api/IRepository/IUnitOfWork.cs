using dadri_api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}