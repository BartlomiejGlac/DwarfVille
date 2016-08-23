using System.Collections.Generic;
using DwarfVille.DomainLogic.Dwarfs;

namespace DwarfVille.DomainLogic.Buildings.MiningDistrict.Brigadiers
{
    internal interface IBrigadierStrategy
    {
        void LetThemWork(IList<Dwarf> dwarfs);
    }
}