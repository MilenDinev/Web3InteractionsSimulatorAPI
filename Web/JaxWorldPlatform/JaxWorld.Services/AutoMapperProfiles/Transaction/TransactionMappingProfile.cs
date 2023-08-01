namespace JaxWorld.Services.AutoMapperProfiles.Transaction
{
    using AutoMapper;
    using Data.Entities.Blockchain.Transactions;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    internal class TransactionMappingProfile : Profile
    {
        internal TransactionMappingProfile()
        {
            this.CreateMap<CreateTransactionModel, Transaction>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.State.ToUpper()));
            this.CreateMap<Transaction, CreatedTransactionModel>();
            this.CreateMap<Transaction, EditedTransactionModel>();
            this.CreateMap<Transaction, DeletedTransactionModel>();
            this.CreateMap<Transaction, TransactionListingModel>();
        }
    }
}
