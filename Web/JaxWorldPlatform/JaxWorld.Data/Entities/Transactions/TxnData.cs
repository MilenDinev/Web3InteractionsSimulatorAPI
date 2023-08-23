namespace JaxWorld.Data.Entities.Transactions
{
    using Microsoft.EntityFrameworkCore;

    public class TxnData : Entity
    {
        public ulong? StartTokenId { get; set; }
        public ulong? QuantityClaimed { get; set; }
        [Precision(18, 2)]
        public decimal? Value { get; set; }
        public string prevURI { get; set; }
        public string newURI { get; set; }
    }
}
