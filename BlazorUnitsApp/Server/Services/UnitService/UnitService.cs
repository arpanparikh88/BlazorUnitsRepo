using BlazorUnitsApp.Server.Data;
using BlazorUnitsApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorUnitsApp.Server.Services.UnitService
{
    public class UnitService : IUnitService
    {
        private readonly DataContext _context;

        public UnitService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Unit>>> GetUnitsAsync()
        {
            var response = new ServiceResponse<List<Unit>>
            {
                Data = await _context.Units.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Unit>> GetUnitAsync(int unitId)
        {
            var response = new ServiceResponse<Unit>();

            var unit = await _context.Units.FindAsync(unitId);

            if (unit == null)
            {
                response.Success = false;
                response.Message = "This unit does not exist";
            }
            else
            {
                response.Data = unit;
            }

            return response;
        }
    }
}
