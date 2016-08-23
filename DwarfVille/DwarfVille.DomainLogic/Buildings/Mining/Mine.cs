using System.Collections.Generic;
using DwarfVille.DomainLogic.Buildings.Mining.Brigadiers;
using DwarfVille.DomainLogic.Dwarfs;

namespace DwarfVille.DomainLogic.Buildings.Mining
{
    // Aggregate: Root of Mine Building graph.
    internal class Mine
    {
        private readonly IBrigadierStrategy _brigadierStrategy;

        public Mine(IBrigadierStrategy brigadierStrategy)
        {
            _brigadierStrategy = brigadierStrategy;
        }

        public void LetThemWork(IList<Dwarf> dwarfs)
        {
            _brigadierStrategy.LetThemWork(dwarfs);
        }

    }
}
