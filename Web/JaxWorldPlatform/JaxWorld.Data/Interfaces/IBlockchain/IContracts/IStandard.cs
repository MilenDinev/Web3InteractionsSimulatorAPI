namespace JaxWorld.Data.Interfaces.IBlockchain.IContracts
{
    using Blockchain.Contracts;

    public interface IStandard
    {
        string Name { get; set; }
        ICollection<Contract> Contracts { get; set; }
    }
}