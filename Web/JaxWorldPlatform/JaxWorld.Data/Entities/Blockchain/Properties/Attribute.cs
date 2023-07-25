namespace JaxWorld.Data.Entities.Blockchain.Properties
{
    using Interfaces.IEntities.IBlockchain.IProperties;
    using Base;

    public class Attribute : Property, IAttribute
    {
        public int ContractId { get; set; }
        public string Value { get; set; }
    }
}
