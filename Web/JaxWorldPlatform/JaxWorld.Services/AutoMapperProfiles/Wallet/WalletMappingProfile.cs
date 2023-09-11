namespace JaxWorld.Services.AutoMapperProfiles.Wallet
{
    using AutoMapper;
    using Data.Entities.Wallets;
    using Models.Requests.BlockchainRequests.WalletModels;
    using Models.Responses.BlockchainResponses.WalletModels;
    using System.Globalization;

    public class WalletMappingProfile : Profile
    {
        public WalletMappingProfile()
        {
            this.CreateMap<CreateWalletModel, Wallet>()
                .ForMember(e => e.NormalizedTag, m => m.MapFrom(m => m.Address.ToUpper()))
                .ForMember(e => e.ProviderId, m => m.MapFrom(m => int.Parse(m.ProviderId)));
            this.CreateMap<Wallet, CreatedWalletModel>()
                .ForMember(m => m.Provider, e => e.MapFrom(e => e.Provider.Name))
                .ForMember(m => m.Balance, e => e.MapFrom(e => e.Balance.ToString("F", CultureInfo.InvariantCulture) + " AVAX"))
                .ForMember(m => m.Owner, e => e.MapFrom(e => e.Owner.UserName));
            this.CreateMap<Wallet, DeletedWalletModel>()
                .ForMember(m => m.Provider, e => e.MapFrom(e => e.Provider.Name))
                .ForMember(m => m.Owner, e => e.MapFrom(e => e.Owner.UserName));
            this.CreateMap<Wallet, WalletListingModel>()
                .ForMember(m => m.Provider, e => e.MapFrom(e => e.Provider.Name))
                .ForMember(m => m.Balance, e => e.MapFrom(e => e.Balance.ToString("F", CultureInfo.InvariantCulture) + " AVAX"))
                .ForMember(m => m.Owner, e => e.MapFrom(e => e.Owner.UserName));
        }
    }
}
