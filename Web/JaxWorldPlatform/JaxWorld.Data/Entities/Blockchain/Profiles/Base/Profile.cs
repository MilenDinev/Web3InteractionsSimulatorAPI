namespace JaxWorld.Data.Entities.Blockchain.Profiles.Base
{
    using Wallets;
    using Contracts;
    using Interfaces.IEntities.IBlockchain.ITokens.IBase;

    public abstract class Profile : Entity, IContractProfile
    {
        public Profile()
        {
            Holders = new HashSet<Wallet>();
        }

        public string Name { get; set; }
        public string Symbol { get; set; }
        public int StandardId { get; set; }
        public Standard Standard { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual ICollection<Wallet> Holders { get; set; }

    }
}
