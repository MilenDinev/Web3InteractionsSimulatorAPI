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
        public string? prevURI { get; set; }
        public string? newURI { get; set; }
    }
}
