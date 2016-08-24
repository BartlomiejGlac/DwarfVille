using System.Collections.Generic;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Probability;

namespace DwarfVille.DomainLogic.Dwarfs.WorkingStrategies
{
    internal class DiggerStrategy : IWorkStrategy
    {
        private readonly IProbabilityGenerator _probabilityGenerator;

        public DiggerStrategy(IProbabilityGenerator probabilityGenerator)
        {
            _probabilityGenerator = probabilityGenerator;
        }

        public IList<MaterialType> WorkOn(IShaft shaft)
        {
            var backPack = new List<MaterialType>();
            int numberOfTries = (int)_probabilityGenerator.Generate(0, 3);
            for (int i = 0; i < numberOfTries; i++)
            {
                backPack.Add(shaft.DigIntoWall());
            }
            return backPack;
        }
    }
}