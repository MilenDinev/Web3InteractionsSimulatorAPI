using JaxWorld.Data.Blockchain.Tokens;
using JaxWorld.Data.Blockchain.Wallets;

namespace JaxWorld.Data.Blockchain.Contracts
{
    public class ContractInfo
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public int CreatedTxnId { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual Wallet Creator { get; set; }
        public int LastModifierId { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public int OwnerId { get; set; }
        public virtual Wallet Owner { get; set; }
        public int ChainId { get; set; }
        public virtual Chain Chain { get; set; }
    }
}