namespace JaxWorld.Data.Entities.Transactions
{
    using Constants;
    using Microsoft.EntityFrameworkCore;

    public class TxnData : Entity
    {
        public ulong? StartTokenId { get; set; }
        public ulong? QuantityClaimed { get; set; }
        [Precision(AttributesParams.DecimalPrecision, AttributesParams.DecimalScale)]
        public decimal? Value { get; set; }
        public string? PrevURI { get; set; }
        public string? NewURI { get; set; }
    }
}
