namespace JaxWorld.Data.Blockchain.Tokens.Erc721Tokens
{
    using Properties;
    using Interfaces.IBlockchain.ITokens;

    public class Erc721aTokenUnit : Token, IErc721aT
    {
        public Erc721aTokenUnit()
        {
            Attributes = new HashSet<Attribute>();
            Utilities = new HashSet<Utility>();
        }

        public string DNA { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
    }
}
