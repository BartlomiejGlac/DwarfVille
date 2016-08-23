using DwarfVille.DomainLogic.Buildings.ShopDistrict;

namespace DwarfVille.DomainLogic.Dwarfs
{
    // Yeah... gates of hell just opened.
    // Main reason is that we need something that would tell us we have to create methods to start interaction with shop.
    // And knowladge about what I need to buy should not be in Shop but in Dwarf.
    // For marketers this would be the best strategy. But for programmers I think it would be better to put this into Dwarf.
    internal interface IBuyable
    {
        void ShopIn(IShop shop);
    }
}