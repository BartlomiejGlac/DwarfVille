using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;

namespace DwarfVille.DomainLogic.Dwarfs.WorkingStrategies
{
    internal interface IWorkStrategy
    {
        void WorkOn(IShaft shaft);
    }
}