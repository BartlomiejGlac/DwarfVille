using DwarfVille.DomainLogic.Probability;

namespace DwarfVille.DomainLogic.Buildings.Mining.Walls
{
    public class TheWall : IDigable
    {
        private readonly IProbabilityGenerator _probabilityGenerator;

        public TheWall(IProbabilityGenerator probabilityGenerator)
        {
            _probabilityGenerator = probabilityGenerator;
        }

        public MaterialType Dig()
        {
            if (_probabilityGenerator.Generate(0, 101) <= 5)
            {
                return MaterialType.Mithrill;
            }
            return MaterialType.None;
        }
    }
}