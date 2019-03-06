using CountryResource.DomainModels;
using CountryResource.Entities;
using CountryResource.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryResource.Infrastructure.Implementation
{
    public class AuditRepository : IAuditRepository
    {
        private readonly DbContext _context;

        public AuditRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<AuditModel> Add(AuditModel audit)
        {
            audit.EntryDate = DateTime.Now;

            var newAudit = new Audit().Assign(audit);

            await _context.AddAsync(audit);
            await _context.SaveChangesAsync();

            return audit;
        }

        public async Task<List<dynamic>> GetAll()
        {
            dynamic audits = await _context.Set<Audit>()
                 .Select(x =>
                     new 
                     {
                           x.AuditId,
                          x.Description,
                          x.EntryDate,
                         x.AuditType,
                     })
                 .ToListAsync();

            return audits;
        }
    }
}
