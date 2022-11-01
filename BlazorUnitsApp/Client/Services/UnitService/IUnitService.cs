namespace BlazorUnitsApp.Client.Services.UnitService
{
    public interface IUnitService
    {
        List<Unit> Units { get; set; }

        Task GetUnits();

        Task<ServiceResponse<Unit>> GetUnit(int unitId);
    }
}
