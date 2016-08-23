using DwarfVille.DomainLogic.Buildings.Mining.Shafts;
using DwarfVille.DomainLogic.Dwarfs.WorkingStrategies;

namespace DwarfVille.DomainLogic.Dwarfs
{
    internal class Dwarf
    {
        private readonly IWorkStrategy _workStrategy;
        private bool _isKilled;

        public Dwarf(IWorkStrategy workStrategy)
        {
            _workStrategy = workStrategy;
        }

        public void KillMe()
        {
            _isKilled = true;
        }

        public void WorkOn(IShaft shaft)
        {
            if (_isKilled)
            {
                throw new AmDeadException();
            }
            _workStrategy.WorkOn(shaft);
        }
    }
}