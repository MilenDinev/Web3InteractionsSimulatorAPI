namespace JaxWorld.Data.Entities.Blockchain.ProfileUnits.Base
{
    using Transactions;
    using Interfaces.IEntities.IBlockchain.ITokens.IBase;
    using JaxWorld.Data.Entities.Blockchain;

    public abstract class ProfileUnit : Entity, IProfileUnit
    {
        public ProfileUnit()
        {
            Transactions = new HashSet<Transaction>();
            Holders = new HashSet<TokenWalletBalance>();
        }

        public string Name { get; set; }
        public virtual ICollection<TokenWalletBalance> Holders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}