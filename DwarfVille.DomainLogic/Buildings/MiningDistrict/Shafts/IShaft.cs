using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Dwarfs;

namespace DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts
{
    internal interface IShaft
    {
        void AssignDwarf(Dwarf assignedToWorkDwarf);
        void DestroyShaft();
        MaterialType DigIntoWall();
    }
}