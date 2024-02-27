using Vehicle_Configurator.Models;

namespace Vehicle_Configurator.Repository
{
    public interface IAlternatecomponentmasterRepository
    {
        List<String> GetCompnameByStd(int mdl_id);

        List<String> GetCompnameByInt(int mdl_id);

        List<String> GetCompnameByExt(int mdl_id);

        List<SubCompPrice> GetConfigurableConfig(int mdl_id, string Comp_name);

        SubCompPrice GetFinalConfig(int Alt_id);
    }
}
