namespace JaxWorld.Models.Constants
{
    internal static class ValidationMessages
    {
        internal const string Required = "{0} is required!";
        internal const string MinMaxLength = "{0} must be between {2} and {1} symbols!";
        internal const string MinLength = "{0} must be atleast {1} symbols!";
        internal const string URL = "{0} must be a valid URL addres!";
        internal const string Email = "Please provide a valid {0} addres!";
        internal const string Network = "{0} is not valid! Please type between \'1\' for Avalanche Mainnet Network and \'2\' for Avalanche FUJI C-Chain.";
        internal const string Provider = "{0} is not valid! Please type between \'1\' or \'metamask\' for metamask, \'2\' or \'coinbase\' for coinbase, \'3\' or \'walletconnect\' for walletconnect.";
    }
}

