namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain.ITokens.IErc721.IProfiles
{
    internal interface IErc721aProfile
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
