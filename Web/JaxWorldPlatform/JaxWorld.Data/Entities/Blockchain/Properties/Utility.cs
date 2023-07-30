namespace JaxWorld.Data.Entities.Blockchain.Properties
{
    using Base;
    using Interfaces.IEntities.IBlockchain.IProperties;

    public class Utility : Property, IUtility
    {
        public decimal Value { get; set; }
    }
}
