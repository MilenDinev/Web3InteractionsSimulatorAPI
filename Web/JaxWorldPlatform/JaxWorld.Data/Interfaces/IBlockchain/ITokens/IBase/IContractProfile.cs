namespace JaxWorld.Data.Interfaces.IBlockchain.ITokens.IBase
{
    internal interface IContractProfile
    {
        string Name { get; set; }
        string Symbol { get; set; }
        int StandardId { get; set; }
        int ContractId { get; set; }
    }
}
