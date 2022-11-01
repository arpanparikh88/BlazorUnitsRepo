namespace BlazorUnitsApp.Client.Services.UnitService
{
    public class UnitService : IUnitService
    {
        private readonly HttpClient _http;

        public UnitService(HttpClient http)
        {
            _http = http;
        }
        public List<Unit> Units { get; set; } = new();
        public async Task GetUnits()
        {
            var result =
                await _http.GetFromJsonAsync<ServiceResponse<List<Unit>>>("api/Unit");

            if (result is not null && result.Data is not null)
            {
                Units = result.Data;
            }
        }

        public async Task<ServiceResponse<Unit>> GetUnit(int unitId)
        {
            var result =
                await _http.GetFromJsonAsync<ServiceResponse<Unit>>($"api/unit/{unitId}");

            return result;
        }
    }
}
