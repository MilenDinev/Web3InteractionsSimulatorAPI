namespace JaxWorld.Data.Entities.Blockchain.Tokens.Base
{
    using Transactions;
    using Interfaces.IEntities.IBlockchain.ITokens.IBase;

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