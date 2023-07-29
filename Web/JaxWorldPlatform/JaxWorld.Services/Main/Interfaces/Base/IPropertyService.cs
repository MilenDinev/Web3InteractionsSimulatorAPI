namespace JaxWorld.Services.Main.Interfaces.Base
{
    using Models.Requests.BlockchainRequests.Interfaces;
    using Data.Interfaces.IEntities.IBlockchain.IProperties;

    internal interface IPropertyService<TProperty, TCModel, TEModel> 
        where TProperty : class, IProperty 
        where TCModel : class, ICreateModel
        where TEModel : class, IEditModel
    {
        Task<TProperty> CreateAsync(TCModel model, int creatorId);
        Task EditAsync(TProperty property, TEModel model, int modifierId);
        Task DeleteAsync(TProperty property, int modifierId);
    }
}
