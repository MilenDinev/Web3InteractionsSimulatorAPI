namespace JaxWorld.Data.Blockchain.Tokens.Erc721Profiles
{
    using Tokens.Erc721Tokens;
    using Interfaces.IBlockchain.IContracts.IErc721;
    using JaxWorld.Data.Blockchain.Contracts;

    public class Erc721aProfile : Token, IErc721a
    {
        public Erc721aProfile()
        {
            Tokens = new HashSet<Erc721aTokenUnit>();
        }
        public int StandardId { get; set; }
        public virtual Standard Standard { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int TotalMinted { get; set; }
        public decimal HighestPriceSale { get; set; }
        public decimal FloorPrice { get; set; }
        public decimal TotalTradingVolume { get; set; }
        public bool IsSupplyCap { get; set; }
        public virtual ICollection<Erc721aTokenUnit> Tokens { get; set; }
    }


}
