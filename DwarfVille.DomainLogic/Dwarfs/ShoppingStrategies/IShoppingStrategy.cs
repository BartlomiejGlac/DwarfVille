using DwarfVille.DomainLogic.Buildings.ShopDistrict;

namespace DwarfVille.DomainLogic.Dwarfs.ShoppingStrategies
{
    internal interface IShoppingStrategy
    {
        void BuyWhatINeed(IShop shop);
    }
}