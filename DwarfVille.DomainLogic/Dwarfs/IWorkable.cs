using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;

namespace DwarfVille.DomainLogic.Dwarfs
{
    // This name sucks ... we need to work this out. But for now it explains what we need.
    // We need do treat Dwarf not as Dwarf but as something that is able to do someting (work, or destroy Shaft).
    internal interface IWorkable
    {
        void WorkOn(IShaft shaft);
    }
}