using Microsoft.EntityFrameworkCore;
using Vehicle_Configurator.DbRepos;
using Vehicle_Configurator.Models;

namespace Vehicle_Configurator.Repository
{
    public class VehicleDetailRepository : IVehicleDetailRepository
    {
        private readonly ScottDbContext context;

        public VehicleDetailRepository(ScottDbContext context)
        {
            this.context = context;
        }

        public async Task<String?> GetImagebyId(int mdl_id)
        {
            var imagePath = await context.ModelMasters
                              .Where(m => m.MdlId == mdl_id)
                              .Select(m => m.ImagePath)
                              .FirstOrDefaultAsync();

            return imagePath;
        }

        public async Task<Price> GetPrice(int mdl_id)
        {
            var result = await context.ModelMasters
                                       .Where(v => v.MdlId == mdl_id)
                                       .Select(v => new Price(v.Price))
                                       .FirstOrDefaultAsync();

            if (result == null)
            {
                // Handle the case where no matching record is found, e.g., throw an exception or return a default Price.
                // For now, let's assume Price has a parameterless constructor.
                return new Price(0); // Replace this with your desired logic.
            }

            return result;
        }

        public async Task<IEnumerable<string>> GetVehicleDetailsByCore(int mdl_id)
        {
            var subTypes = from c in context.ComponentMasters
                           join v in context.VehicleDetails on c.CompId equals v.CompId
                           where v.CompType == "c" && v.MdlId == mdl_id
                           select c.SubType;
            var subTypesList = await subTypes.ToListAsync();
            return subTypesList;
        }

        public async Task<IEnumerable<string>> GetVehicleDetailsByExterior(int mdl_id)
        {
            var subTypes = from c in context.ComponentMasters
                           join v in context.VehicleDetails on c.CompId equals v.CompId
                           where v.CompType == "e" && v.MdlId == mdl_id
                           select c.SubType;
            var subTypesList = await subTypes.ToListAsync();
            return subTypesList;
        }

        public async Task<IEnumerable<string>> GetVehicleDetailsByInterior(int mdl_id)
        {
            var subTypes = from c in context.ComponentMasters
                           join v in context.VehicleDetails on c.CompId equals v.CompId
                           where v.CompType == "i" && v.MdlId == mdl_id
                           select c.SubType;
            var subTypesList = await subTypes.ToListAsync();
            return subTypesList;
        }

        public async Task<IEnumerable<string>> GetVehicleDetailsByStandard(int mdl_id)
        {
            var subTypes = from c in context.ComponentMasters
                           join v in context.VehicleDetails on c.CompId equals v.CompId
                           where v.CompType == "s" && v.MdlId == mdl_id
                           select c.SubType;
            var subTypesList = await subTypes.ToListAsync();
            return subTypesList;
        }
    }
}
