using Vehicle_Configurator.DbRepos;
using Vehicle_Configurator.Models;

namespace Vehicle_Configurator.Repository
{
    public class AlternatecomponentRepository : IAlternatecomponentmasterRepository
    {
        private readonly ScottDbContext context;

        public AlternatecomponentRepository(ScottDbContext context)
        {
            this.context = context;
        }

        public List<String> GetCompnameByExt(int mdl_id)
        {
            var resultList = (from v in context.VehicleDetails
                              join c in context.ComponentMasters on v.CompId equals c.CompId
                              where v.IsConfigurable == "y" && v.MdlId == mdl_id && v.CompType == "e"
                              select c.CompName).Distinct().ToList();
            return resultList;
        }


        public List<String> GetCompnameByInt(int mdl_id)
        {
            var resultList = (from v in context.VehicleDetails
                              join c in context.ComponentMasters on v.CompId equals c.CompId
                              where v.IsConfigurable == "y" && v.MdlId == mdl_id && v.CompType == "i"
                              select c.CompName).Distinct().ToList();
            return resultList;
        }
        public List<String> GetCompnameByStd(int mdl_id)
        {
            var resultList = (from v in context.VehicleDetails
                              join c in context.ComponentMasters on v.CompId equals c.CompId
                              where v.IsConfigurable == "y" && v.MdlId == mdl_id && v.CompType == "s"
                              select c.CompName).Distinct().ToList();
            return resultList;
        }

        List<SubCompPrice> IAlternatecomponentmasterRepository.GetConfigurableConfig(int mdl_id, string Comp_name)
        {
            return (from a in context.AlternateComponentMasters
                    join c in context.ComponentMasters on a.CompId equals c.CompId
                    where c.CompName == Comp_name && a.MdlId == mdl_id
                    select new SubCompPrice
                    {
                        SubType = c.SubType,
                        DeltaPrice = a.DeltaPrice,
                        AltId = a.AltId
                    }).ToList();
        }

        SubCompPrice IAlternatecomponentmasterRepository.GetFinalConfig(int Alt_Id)
        {
            return (from c in context.ComponentMasters
                    join a in context.AlternateComponentMasters on c.CompId equals a.AltCompId
                    where a.AltId == Alt_Id
                    select new SubCompPrice
                    {
                        SubType = c.SubType,
                        DeltaPrice = a.DeltaPrice,
                        AltId = a.AltId
                    }).FirstOrDefault();
        }
    }
}
