namespace JaxWorld.Services.AutoMapperProfiles.User
{
    using AutoMapper;
    using Data.Entities;
    using Models.Requests.EntityRequests;
    using Models.Responses.EntityResponses.UserModels;

    internal class UserMappingProfile : Profile
    {
        internal UserMappingProfile()
        {
            this.CreateMap<CreateUserModel, User>()
                .ForMember(e => e.NormalizedName, m => m.MapFrom(m => m.UserName.ToUpper()));
            this.CreateMap<User, CreatedUserModel>();
            this.CreateMap<User, EditedUserModel>();
            this.CreateMap<User, DeletedUserModel>();
            this.CreateMap<User, UserListingModel>();
        }
    }
}
