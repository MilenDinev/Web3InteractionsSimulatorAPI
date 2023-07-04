namespace JaxWorld.Data.Interfaces.IBlockchain.ITokens
{
    public interface IToken
    {
        string Name { get; set; }
        string Description { get; set; }
        string Image { get; set; }
        string ExternalUrl { get; set; }
        int ContractId { get; set; }
        int MintedTxnId { get; set; }
        int MinterId { get; set; }
    }
}
