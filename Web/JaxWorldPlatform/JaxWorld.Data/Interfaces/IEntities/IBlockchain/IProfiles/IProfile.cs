namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain.IProfiles
{
    internal interface IProfile
    {
        string Name { get; set; }
        string Symbol { get; set; }
        int StandardId { get; set; }
        string Description { get; set; }
        int TotalSupply { get; set; }
        int TotalMinted { get; set; }
        int ContractId { get; set; }
    }
}
