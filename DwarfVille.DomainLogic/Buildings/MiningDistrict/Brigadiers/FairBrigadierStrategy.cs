using System.Collections.Generic;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Dwarfs;
using DwarfVille.DomainLogic.Probability;

namespace DwarfVille.DomainLogic.Buildings.MiningDistrict.Brigadiers
{
    internal class FairBrigadierStrategy : IBrigadierStrategy
    {
        private readonly IList<IShaft> _avalilableShafts;

        public FairBrigadierStrategy(int numberOfShafts = 2)
        {
            _avalilableShafts = new List<IShaft>();
            for (int i=0;i< numberOfShafts;i++)
            {
                // Awww thats awful :(
                _avalilableShafts.Add(new Shaft(new TheWall(new ProbabilityGenerator())));
            }
        }

        public void LetThemWork(IList<Dwarf> dwarfs)
        {
            int i = 0;
            foreach (var dwarf in dwarfs)
            {
                var shaft = _avalilableShafts[i%2];
                shaft.AssignDwarf(dwarf);
                dwarf.WorkOn(shaft);
            }
        }
    }
}