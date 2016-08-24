using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;

namespace DwarfVille.DomainLogic.Dwarfs
{
    // This name sucks ... we need to work this out. But for now it explains what we need.
    // We need do treat Dwarf not as Dwarf but as something that is able to do someting (work, or destroy Shaft).
    public interface IWorkable
    {
        void WorkOn(IShaft shaft);
        // This method should not be here probably. Is this really related to work process?
        void KillMe();
    }
}