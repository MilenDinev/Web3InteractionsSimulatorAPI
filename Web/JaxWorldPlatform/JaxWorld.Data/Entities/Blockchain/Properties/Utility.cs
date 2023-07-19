namespace JaxWorld.Data.Entities.Blockchain.Properties
{
    using Interfaces.IEntities.IBlockchain.IProperties;

    public class Utility : Entity, IUtility
    {
        public int ContractId { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
    }
}
