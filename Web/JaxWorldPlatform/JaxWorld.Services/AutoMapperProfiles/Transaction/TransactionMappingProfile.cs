namespace JaxWorld.Services.AutoMapperProfiles.Transaction
{
    using AutoMapper;
    using Data.Entities.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            this.CreateMap<CreateTransactionModel, Transaction>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.TxnHash.ToUpper()))
                .ForMember(e => e.CreatorId, m => m.Ignore())
                .ForMember(e => e.InitiatorId, m => m.Ignore())
                .ForMember(e => e.TargetId, m => m.Ignore());
            this.CreateMap<Transaction, TransactionListingModel>();
            this.CreateMap<Transaction, TransactionListingModel>();
        }
    }
}
