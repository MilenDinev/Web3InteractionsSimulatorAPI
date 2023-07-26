namespace JaxWorld.Data.Interfaces.IEntities.IBlockchain
{
    using Entities.Blockchain.Contracts;

    public interface IStandard
    {
        string Name { get; set; }
        ICollection<Contract> Contracts { get; set; }
    }
}