namespace JaxWorld.Data.Entities.Contracts
{
    using Constants;
    using Microsoft.EntityFrameworkCore;
    using Profiles;
    using Transactions;
    using Wallets;

    public class Contract : Entity
    {
        public Contract()
        {
            Transactions = new HashSet<Transaction>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal Balance { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal EstimatedValue { get; set; }
        public int CreatorWalletId { get; set; }
        public virtual Wallet CreatorWallet { get; set; }
        public virtual Profile Profile { get; set; }
        public int NetworkId { get; set; }
        public virtual Network Network { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
