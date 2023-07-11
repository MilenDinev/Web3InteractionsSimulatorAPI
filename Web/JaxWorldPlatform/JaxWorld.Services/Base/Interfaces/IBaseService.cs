namespace JaxWorld.Services.Base.Interfaces
{
    using Data.Entities;

    internal interface IBaseService
    {

        Task SaveModificationAsync(User user, int modifierId);
    }
}
