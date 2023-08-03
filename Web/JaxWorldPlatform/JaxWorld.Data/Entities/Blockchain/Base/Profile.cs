namespace JaxWorld.Data.Entities.Blockchain.Base
{
    using Blockchain.Contracts;
    using Interfaces.IEntities.IBlockchain.IBase;

    public abstract class Profile : Entity, IProfile
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
