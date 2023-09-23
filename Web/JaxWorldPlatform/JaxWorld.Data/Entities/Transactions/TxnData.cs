namespace JaxWorld.Data.Entities.Transactions
{
    using Microsoft.EntityFrameworkCore;
    using Base;
    using Constants;

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
