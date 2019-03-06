using CountryResource.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryResource.Infrastructure.Interface
{
   public interface IAuditRepository
    {
        Task<AuditModel> Add(AuditModel country);
        Task<List<dynamic>> GetAll();
    }
}
