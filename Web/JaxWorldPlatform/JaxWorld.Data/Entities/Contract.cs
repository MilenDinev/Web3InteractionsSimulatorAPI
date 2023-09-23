namespace JaxWorld.Data.Entities
{
    using Microsoft.EntityFrameworkCore;
    using Base;
    using Wallets;
    using Constants;
    using Transactions;

    public class Contract : Entity
    {
        public Contract()
        {
            Transactions = new HashSet<Transaction>();
            ApprovedBy = new HashSet<Wallet>();
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
        public virtual ICollection<Wallet> ApprovedBy { get; set; }
    }
}
