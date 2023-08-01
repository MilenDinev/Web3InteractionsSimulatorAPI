namespace JaxWorld.Services.AutoMapperProfiles.Wallet
{
    using AutoMapper;
    using Data.Entities.Blockchain.Wallets;
    using Models.Requests.BlockchainRequests.WalletModels;
    using Models.Responses.BlockchainResponses.WalletModels;

    internal class WalletMappingProfile : Profile
    {
        internal WalletMappingProfile()
        {
            this.CreateMap<CreateWalletModel, Wallet>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.Address.ToUpper()));
            this.CreateMap<Wallet, CreatedWalletModel>();
            this.CreateMap<Wallet, EditedWalletModel>();
            this.CreateMap<Wallet, DeletedWalletModel>();
            this.CreateMap<Wallet, WalletListingModel>();
        }
    }
}
