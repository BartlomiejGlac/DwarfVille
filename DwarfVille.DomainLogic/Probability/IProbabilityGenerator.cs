namespace DwarfVille.DomainLogic.Probability
{
    public interface IProbabilityGenerator
    {
        // To Do: should this be double or probability?
        double Generate(int minValue, int maxValue);
    }
}