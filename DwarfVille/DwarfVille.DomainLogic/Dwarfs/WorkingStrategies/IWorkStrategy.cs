using DwarfVille.DomainLogic.Buildings.Mining.Shafts;

namespace DwarfVille.DomainLogic.Dwarfs.WorkingStrategies
{
    internal interface IWorkStrategy
    {
        void WorkOn(IShaft shaft);
    }
}