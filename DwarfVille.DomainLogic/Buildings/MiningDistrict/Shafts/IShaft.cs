using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Dwarfs;

namespace DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts
{
    public interface IShaft
    {
        void AssignDwarf(IWorkable assignedToWorkDwarf);
        void DestroyShaft();
        MaterialType DigIntoWall();
    }
}