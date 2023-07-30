namespace JaxWorld.Data.Entities.Blockchain.Properties.Base
{
    using Interfaces.IEntities.IBlockchain.IProperties;

    public abstract class Property : Entity, IProperty
    {
        public string Type { get; set; }
    }
}
