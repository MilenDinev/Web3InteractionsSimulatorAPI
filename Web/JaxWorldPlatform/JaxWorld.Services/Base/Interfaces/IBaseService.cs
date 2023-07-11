namespace JaxWorld.Services.Base.Interfaces
{

    internal interface IBaseService<TEntity>
    {

        Task SaveModificationAsync(TEntity user, int modifierId);
    }
}
