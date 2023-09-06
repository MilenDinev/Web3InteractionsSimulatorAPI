namespace JaxWorld.Web.Extensions
{
    using Constants;
    using Microsoft.Extensions.DependencyInjection;
    using Services.Handlers;
    using Services.Handlers.Interfaces;
    using Services.Handlers.Validation;
    using Services.Main;
    using Services.Main.Interfaces;
    using Services.Main.Interfaces.Properties;
    using Services.Main.Interfaces.Units;
    using Services.Main.Properties;
    using Services.Main.Units;
    using Services.Managers;
    using Services.Managers.Interfaces;
    using System.Reflection;

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
            services.AddTransient<IWalletValidator, WalletValidator>();
            services.AddHttpContextAccessor();
        }
    }
}
