namespace JaxWorld.Web.Extensions
{
    using System.Reflection;
    using Microsoft.Extensions.DependencyInjection;
    using Constants;
    using Services.Main;
    using Services.Handlers;
    using Services.Managers;
    using Services.Main.Units;
    using Services.Main.Properties;
    using Services.Main.Interfaces;
    using Services.Managers.Interfaces;
    using Services.Handlers.Interfaces;
    using Services.Main.Interfaces.Units;
    using Services.Main.Interfaces.Properties;

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
            services.AddTransient<IEntityChecker, EntityChecker>();
            services.AddTransient<IValidator, Validator>();
            services.AddHttpContextAccessor();
        }
    }
}
