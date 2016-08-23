using DwarfVille.DomainLogic.Buildings.Mining.Walls;
using DwarfVille.DomainLogic.Dwarfs;

namespace DwarfVille.DomainLogic.Buildings.Mining.Shafts
{
    internal interface IShaft
    {
        void AssignDwarf(Dwarf assignedToWorkDwarf);
        void DestroyShaft();
        MaterialType DigIntoWall();
    }
}