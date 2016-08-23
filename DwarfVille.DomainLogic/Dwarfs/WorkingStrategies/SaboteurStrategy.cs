using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;

namespace DwarfVille.DomainLogic.Dwarfs.WorkingStrategies
{
    internal class SaboteurStrategy : IWorkStrategy
    {
        public void WorkOn(IShaft shaft)
        {
            shaft.DestroyShaft();
        }
    }
}