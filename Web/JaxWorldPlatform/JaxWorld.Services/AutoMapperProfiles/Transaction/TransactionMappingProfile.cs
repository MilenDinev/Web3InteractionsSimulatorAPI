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
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.TxnHash.ToUpper()));
            this.CreateMap<Transaction, DeployedContractTransactionModel>();
            this.CreateMap<Transaction, TransactionListingModel>();
            this.CreateMap<Transaction, TransactionListingModel>();
            this.CreateMap<TransferUnitTransactionModel, DeployedContractTransactionModel>();
        }
    }
}
