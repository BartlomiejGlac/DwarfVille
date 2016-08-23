using System.Collections.Generic;
using DwarfVille.DomainLogic.Buildings.MiningDistrict.Walls;
using DwarfVille.DomainLogic.Dwarfs;

namespace DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts
{
    internal class Shaft : IShaft
    {
        private readonly IList<Dwarf> _assignedToWarkDwarfes;
        private IDigable _digable;
        private bool _isDestroyed;

        public Shaft(IDigable digable)
        {
            _digable = digable;
            _assignedToWarkDwarfes = new List<Dwarf>();
        }

        public void AssignDwarf(Dwarf assignedToWorkDwarf)
        {
            if (_isDestroyed)
            {
                throw new ShaftWasDestroyedException();
            }
            _assignedToWarkDwarfes.Add(assignedToWorkDwarf);
        }

        public void DestroyShaft()
        {
            _isDestroyed = true;
            foreach (var assignedToWarkDwarf in _assignedToWarkDwarfes)
            {
                assignedToWarkDwarf.KillMe();
            }
        }

        public MaterialType DigIntoWall()
        {
            return _digable.Dig();
        }
    }
}