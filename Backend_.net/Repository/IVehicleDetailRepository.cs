using Vehicle_Configurator.Models;

namespace Vehicle_Configurator.Repository
{
    public interface IVehicleDetailRepository
    {
        Task<IEnumerable<String>> GetVehicleDetailsByCore(int mdl_id);

        Task<IEnumerable<String>> GetVehicleDetailsByStandard(int mdl_id);

        Task<IEnumerable<String>> GetVehicleDetailsByInterior(int mdl_id);

        Task<IEnumerable<String>> GetVehicleDetailsByExterior(int mdl_id);

        Task<Price> GetPrice(int mdl_id);
        Task<String?> GetImagebyId(int mdl_id);
    }
}
