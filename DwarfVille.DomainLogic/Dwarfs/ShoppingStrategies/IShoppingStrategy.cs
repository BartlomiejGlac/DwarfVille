using DwarfVille.DomainLogic.Buildings.ShopDistrict;

namespace DwarfVille.DomainLogic.Dwarfs.ShoppingStrategies
{
    public interface IShoppingStrategy
    {
        void BuyWhatINeed(IShop shop);
    }
}