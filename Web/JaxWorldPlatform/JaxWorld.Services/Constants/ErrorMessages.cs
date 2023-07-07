namespace JaxWorld.Services.Constants
{
    internal static class ErrorMessages
    {
        internal const string InvalidCredentials = "Invalid credentials, please try again!";
        internal const string InvalidPublicationDate = "Please provide valid publication date in format 'dd/MM/yyyy'!";
        internal const string EntityDoesNotExist = @"{0} does not exist!";
        internal const string EntityIdDoesNotExist = @"{0} with id '{1}' does not exist!";
        internal const string EntityAlreadyExists = @"{0} already exists in our system!";
        internal const string EntityAlreadyAssignedId = @"{0} with id '{1}' has already been assigned to this {2}!";
        internal const string EntityAlreadyContained = @"{0} already exists in this collection!";
        internal const string EntityHasBeenDeleted = @"{0} has already been deleted and cannot be modified!";
        internal const string AlreadyFavoriteId = @"{0} with id '{1}' already exists in favorites!";
        internal const string NotFavoriteId = @"{0} with id '{1}' does not exists in favorites!";
        internal const string AlreadyFollowing = @"{0} with id '{1}' has already been followed by you!";
        internal const string NotFollowing = @"{0} with id '{1}' is not followed by you!";
        internal const string FollowingItSelf = @"Following yourself is forbidden!";
    }
}
