using DwarfVille.DomainLogic.Buildings.MiningDistrict.Shafts;
using DwarfVille.DomainLogic.Buildings.ShopDistrict;
using DwarfVille.DomainLogic.Dwarfs.ShoppingStrategies;
using DwarfVille.DomainLogic.Dwarfs.WorkingStrategies;

namespace DwarfVille.DomainLogic.Dwarfs
{
    public class Dwarf : IWorkable, IBuyable
    {
        private readonly IWorkStrategy _workStrategy;
        private readonly IShoppingStrategy _shoppingStrategy;
        private bool _isKilled;

        public Dwarf(IWorkStrategy workStrategy, IShoppingStrategy shoppingStrategy)
        {
            _workStrategy = workStrategy;
            _shoppingStrategy = shoppingStrategy;
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

        public void ShopIn(IShop shop)
        {
            _shoppingStrategy.BuyWhatINeed(shop);
        }
    }
}