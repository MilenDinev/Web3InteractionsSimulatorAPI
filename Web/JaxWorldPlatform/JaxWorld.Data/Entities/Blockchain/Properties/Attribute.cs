namespace JaxWorld.Data.Entities.Blockchain.Properties
{
    using Base;
    using Interfaces.IEntities.IBlockchain.IProperties;

    public class Attribute : Property, IAttribute
    {
        public string Value { get; set; }
    }
}
