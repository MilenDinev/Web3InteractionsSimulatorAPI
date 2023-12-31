﻿namespace JaxWorld.Data.Entities.Transactions
{
    using Base;

    public class TransactionState : Entity
    {
        public TransactionState()
        {
            Transactions = new HashSet<Transaction>();
        }

        public string State { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
