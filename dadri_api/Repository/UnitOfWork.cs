using dadri_api.Data;
using dadri_api.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Country> _contries;
        private IGenericRepository<Hotel> _hotels;
        private IGenericRepository<TownshipQuarter> _townshipQuarters ;

        private IGenericRepository<TownshipQuarterArchive> _townshipQuarterArchives ;

        private IGenericRepository<TypeIndicator> _typeIndicators ;

        private IGenericRepository<URole> _uRoles ;
        

        private IGenericRepository<UserDept> _userDepts ;

        private IGenericRepository<UserDeptGroup> _userDeptGroups ;

        private IGenericRepository<UserEmployer> _userEmployers ;

        private IGenericRepository<UserGrade> _userGrades ;

        private IGenericRepository<UserPersonalArea> _userPersonalAreas ;

        private IGenericRepository<UserProject> _userProjects ;

        private IGenericRepository<UserRegister> _userRegisters ;

        private IGenericRepository<UserRole> _userRoles ;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;            
        }
        public IGenericRepository<Country> Countries => _contries??= new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ??= new GenericRepository<Hotel>(_context);

        public IGenericRepository<TownshipQuarter> TownshipQuarters => _townshipQuarters ??= new GenericRepository<TownshipQuarter>(_context);

        public IGenericRepository<TownshipQuarterArchive> TownshipQuarterArchives => _townshipQuarterArchives ??= new GenericRepository<TownshipQuarterArchive>(_context);

        public IGenericRepository<TypeIndicator> TypeIndicators => _typeIndicators ??= new GenericRepository<TypeIndicator>(_context);

        public IGenericRepository<URole> URoles => _uRoles ??= new GenericRepository<URole>(_context);

        public IGenericRepository<UserDept> UserDepts => _userDepts ??= new GenericRepository<UserDept>(_context);

        public IGenericRepository<UserDeptGroup> UserDeptGroups => _userDeptGroups ??= new GenericRepository<UserDeptGroup>(_context);

        public IGenericRepository<UserEmployer> UserEmployers => _userEmployers ??= new GenericRepository<UserEmployer>(_context);

        public IGenericRepository<UserGrade> UserGrades => _userGrades ??= new GenericRepository<UserGrade>(_context);

        public IGenericRepository<UserPersonalArea> UserPersonalAreas => _userPersonalAreas ??= new GenericRepository<UserPersonalArea>(_context);

        public IGenericRepository<UserProject> UserProjects => _userProjects ??= new GenericRepository<UserProject>(_context);

        public IGenericRepository<UserRegister> UserRegisters => _userRegisters ??= new GenericRepository<UserRegister>(_context);

        public IGenericRepository<UserRole> UserRoles => _userRoles ??= new GenericRepository<UserRole>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
