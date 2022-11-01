using BlazorUnitsApp.Shared;

namespace BlazorUnitsApp.Server.Services.UnitService
{
    public interface IUnitService
    {
        Task<ServiceResponse<List<Unit>>> GetUnitsAsync();

        Task<ServiceResponse<Unit>> GetUnitAsync(int unitId);

    }
}
