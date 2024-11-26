using Enterprise.DataAccess.Repository.IRepository;
using Enterprise.Models;
using Enterprise_Application.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company> , ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
