namespace JaxWorld.Services.Main.Interfaces.Base
{
    using Data.Interfaces.IEntities.IBase;
    using Models.Requests.BlockchainRequests.Interfaces;

    public interface IPropertyService<TProperty, TCModel, TEModel> 
        where TProperty : class, IProperty 
        where TCModel : class, ICreateModel
        where TEModel : class, IEditModel
    {
        Task<TProperty> CreateAsync(TCModel model, int creatorId);
        Task EditAsync(TProperty property, TEModel model, int modifierId);
        Task DeleteAsync(TProperty property, int modifierId);
    }
}
