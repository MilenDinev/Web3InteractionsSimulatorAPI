using JaxWorld.Data.Blockchain.Contracts;

namespace JaxWorld.Data.Interfaces.IBlockchain.IContracts
{
    public interface IContract
    {
        string Name { get; set; }
        string Address { get; set; }
        ContractInfo ContractData { get; set; }
        ContractOverview ContractOverviewData { get; set; }
    }
}
