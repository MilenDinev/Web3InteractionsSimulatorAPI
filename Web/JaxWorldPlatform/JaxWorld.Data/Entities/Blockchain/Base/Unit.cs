namespace JaxWorld.Data.Entities.Blockchain.Base
{
    using Data.Interfaces.IEntities.IBlockchain.IBase;

    public abstract class Unit : Entity, IUnit
    {
        public string Name { get; set; }
    }
}