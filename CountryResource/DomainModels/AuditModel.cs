using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryResource.DomainModels
{
    public class AuditModel
    {
        public Guid AuditId { get; set; }
        public string AuditType { get; set; }
        public Nullable<DateTime> EntryDate { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public string AuthUser { get; set; }
    }
}
