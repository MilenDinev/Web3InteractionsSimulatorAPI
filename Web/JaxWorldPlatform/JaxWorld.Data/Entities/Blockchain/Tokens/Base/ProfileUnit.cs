namespace JaxWorld.Data.Entities.Blockchain.Tokens.Base
{
    using Interfaces.IEntities.IBlockchain.ITokens.IBase;

    public abstract class ProfileUnit : IProfileUnit
    { 
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
}