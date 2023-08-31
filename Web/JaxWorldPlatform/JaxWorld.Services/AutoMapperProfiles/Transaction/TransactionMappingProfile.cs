namespace JaxWorld.Services.AutoMapperProfiles.Transaction
{
    using AutoMapper;
    using Data.Entities.Transactions;
    using JaxWorld.Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Requests.BlockchainRequests;
    using Models.Requests.BlockchainRequests.TransactionModels;
    using Models.Responses.BlockchainResponses.TransactionModels;

    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            this.CreateMap<CreateTransactionModel, Transaction>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.State.ToUpper()));
            this.CreateMap<Transaction, DeployedContractTransactionModel>();
            this.CreateMap<Transaction, TransactionListingModel>();
            this.CreateMap<Transaction, TransactionListingModel>();
            this.CreateMap<TransferUnitTransactionModel, DeployedContractTransactionModel>();
        }
    }
}
