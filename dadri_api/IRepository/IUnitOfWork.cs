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
        IGenericRepository<TownshipQuarter> TownshipQuarters { get; }
        IGenericRepository<TownshipQuarterArchive> TownshipQuarterArchives { get; }
        IGenericRepository<TypeIndicator> TypeIndicators { get; }
        IGenericRepository<URole> URoles { get; }
        IGenericRepository<User> Users { get; }
        IGenericRepository<UserDept> UserDepts { get; }
        IGenericRepository<UserDeptGroup> UserDeptGroups { get; }
        IGenericRepository<UserEmployer> UserEmployers { get; }
        IGenericRepository<UserGrade> UserGrades { get; }
        IGenericRepository<UserLogin> UserLogins { get; }
        IGenericRepository<UserPersonalArea> UserPersonalAreas { get; }
        IGenericRepository<UserProject> UserProjects { get; }
        IGenericRepository<UserRegister> UserRegisters { get; }
        IGenericRepository<UserRole> UserRoles { get; }

        Task Save();
    }
}