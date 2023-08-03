namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain.IBase
{
    public interface IProfile
    {
        string Name { get; set; }
        string Symbol { get; set; }
        int StandardId { get; set; }
        int ContractId { get; set; }
    }
}
