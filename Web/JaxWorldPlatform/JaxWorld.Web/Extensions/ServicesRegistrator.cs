namespace JaxWorld.Web.Extensions
{
    using System.Reflection;
    using Constants;
    using Microsoft.Extensions.DependencyInjection;
    using Services.Handlers;
    using Services.Handlers.Interfaces;
    using Services.Main;
    using Services.Main.Interfaces;
    using Services.Main.Interfaces.Properties;
    using Services.Main.Interfaces.Units;
    using Services.Main.Properties;
    using Services.Main.Units;
    using Services.Managers;
    using Services.Managers.Interfaces;

    public static class ServicesRegistrator
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.Load(AutoMapperConfigValues.Assembly));
            services.AddTransient<IUserManager, JaxWorldUserManager>();
            services.AddTransient<ITransactionDeployer, TransactionDeployer>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<INetworkService, NetworkService>();
            services.AddTransient<IContractService, ContractService>();
            services.AddTransient<IProfileService, ProfileService>();
            services.AddTransient<IErc721aUnitService, Erc721aUnitService>();
            services.AddTransient<ITransactionService, TransactionService>();
            services.AddTransient<IBlockService, BlockService>();
            services.AddTransient<IAttributeService, AttributeService>();
            services.AddTransient<IUtilityService, UtilityService>();
            services.AddTransient<IWalletService, WalletService>();
            services.AddTransient<IFinder, Finder>();
            services.AddHttpContextAccessor();
        }
    }
}
