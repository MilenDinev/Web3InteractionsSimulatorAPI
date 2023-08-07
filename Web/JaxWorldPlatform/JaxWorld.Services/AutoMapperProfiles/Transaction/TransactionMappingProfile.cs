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
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.State.ToUpper()));
            this.CreateMap<Transaction, CreatedTransactionModel>();
            this.CreateMap<Transaction, EditedTransactionModel>();
            this.CreateMap<Transaction, DeletedTransactionModel>();
            this.CreateMap<Transaction, TransactionListingModel>();
        }
    }
}
