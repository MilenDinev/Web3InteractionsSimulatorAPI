namespace JaxWorld.Data.Entities.Blockchain.Properties
{
    using Interfaces.IEntities.IBlockchain.IProperties;

    public class Attribute : IAttribute
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

    }
}
