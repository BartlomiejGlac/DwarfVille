using System.Collections.Generic;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;

namespace DwarfVille.DomainLogic.Dwarfs.WorkingStrategies
{
    internal class SaboteurStrategy : IWorkStrategy
    {
        public IList<MaterialType> WorkOn(IShaft shaft)
        {
            shaft.DestroyShaft();
            // I don't like this. There should be no such thing in code. All classes implementing this interface should react in same manner.
            // So maybe there should be another place for materials keep in backpack. Maybe some kind of transforamtion service.
            return new List<MaterialType>();
        }
    }
}