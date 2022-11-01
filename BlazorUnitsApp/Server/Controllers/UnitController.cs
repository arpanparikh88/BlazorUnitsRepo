using BlazorUnitsApp.Server.Data;
using BlazorUnitsApp.Server.Services.UnitService;
using BlazorUnitsApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorUnitsApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitService _unitService;

        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }
        
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Unit>>>> GetUnits()
        {

            var result = await _unitService.GetUnitsAsync();
            
            return Ok(result);
        }

        [HttpGet("{unitId}")]
        public async Task<ActionResult<ServiceResponse<Unit>>> GetUnit(int unitId)
        {
            var result = await _unitService.GetUnitAsync(unitId);

            return Ok(result);
        }
    }
}
