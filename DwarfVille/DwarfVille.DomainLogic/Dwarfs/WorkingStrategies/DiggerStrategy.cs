using DwarfVille.DomainLogic.Buildings.Mining.Shafts;
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

        public void WorkOn(IShaft shaft)
        {
            int numberOfTries = (int)_probabilityGenerator.Generate(0, 3);
            for (int i = 0; i < numberOfTries; i++)
            {
                shaft.DigIntoWall();
            }
        }
    }
}