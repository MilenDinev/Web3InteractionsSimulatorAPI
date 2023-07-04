namespace JaxWorld.Data.Blockchain.Contracts.Erc721
{
    using Tokens.Erc721Tokens;
    using Interfaces.IBlockchain.IContracts.IErc721;
    using JaxWorld.Data.Blockchain.Contracts;

    public class Erc721a : Contract, IErc721a
    {
        public Erc721a()
        {
            Tokens = new HashSet<Erc721aT>();
        }

        public string Symbol { get; set; }
        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int TotalMinted { get; set; }
        public decimal HighestPriceSale { get; set; }
        public decimal FloorPrice { get; set; }
        public decimal TotalTradingVolume { get; set; }
        public bool IsSupplyCap { get; set; }
        public virtual ICollection<Erc721aT> Tokens { get; set; }
    }


}
