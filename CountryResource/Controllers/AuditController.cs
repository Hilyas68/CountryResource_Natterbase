using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CountryResource.DomainModels;
using CountryResource.Infrastructure.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryResource.Controllers
{
    //[Route("api")]
    //public class AuditController : ControllerBase
    //{
    //    private readonly IAuditRepository _auditRepository;

    //    public AuditController(IAuditRepository auditRepository)
    //    {
    //        _auditRepository = auditRepository;
    //    }

    //    [HttpGet("audits")]

    //    public async Task<IActionResult> GetActivities()
    //    {
    //        var audits = await _auditRepository.GetAll();

    //        return Ok(new ApiResponse<List<AuditModel>>()
    //        {
    //            Data = audits,
    //            Message = "Successful",
    //            StatusCode = HttpStatusCode.OK
    //        });
    //    }
    //}
}