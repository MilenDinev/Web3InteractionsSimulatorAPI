namespace JaxWorld.Services.Constants
{
    public static class ErrorMessages
    {
        internal const string InvalidCredentials = "Invalid credentials, please try again!";
        internal const string OperationExecutionRejected = "Operation has been rejected!";
        internal const string AddresableEntityAlreadyExists = @"{0} with address:'{1}' already exists!";
        internal const string NamedEntityAlreadyExists = @"{0} with name:'{1}' already exists!";
        internal const string NotAvailableWalletBalance = @"{0} : does not have required balance to perform this action!";
        internal const string ContractNotApproved = @"{0} has not been approved by {1}!";
        internal const string EntityDoesNotExist = @"{0} does not exist!";
        internal const string EntityAlreadyExists = @"{0} already exists in our system!";
        internal const string UnitNotForSale = @"{0} with ID '{1}' is not for sale!";
        internal const string UnitAlreadyListedForSale = @"{0} with ID '{1}' has been already listed for sale!";
        internal const string WalletNotUnitOwner = @"{0} is not the owner of unit with ID '{1}'!";
    }
}
