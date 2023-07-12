namespace JaxWorld.Data.Blockchain.Tokens.Base
{
    using Transactions;
    using Interfaces.IBlockchain.ITokens.IBase;

    public abstract class ProfileUnit : IProfileUnit
    {
        public ProfileUnit()
        {
            this.Transactions = new HashSet<Transaction>();
            this.Holders = new HashSet<TokenWalletBalance>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ContractProfileId { get; set; }
        public virtual ContractProfile ContractProfile { get; set; }
        public int MintedTxnId { get; set; }
        public virtual Transaction MintedTxn { get; set; }
        public virtual ICollection<TokenWalletBalance> Holders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}