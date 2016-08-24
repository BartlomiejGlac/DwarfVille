using System.Collections.Generic;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;

namespace DwarfVille.DomainLogic.Dwarfs.WorkingStrategies
{
    public interface IWorkStrategy
    {
        IList<MaterialType> WorkOn(IShaft shaft);
    }
}