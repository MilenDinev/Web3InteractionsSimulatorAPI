namespace JaxWorld.Data.Blockchain.Tokens.Erc721.Profiles
{
    using Base;
    using Units;
    using Interfaces.IBlockchain.ITokens.IErc721.IProfiles;

    public class Erc721aProfile : ContractProfile, IErc721aProfile
    {
        public Erc721aProfile()
        {
            Units = new HashSet<Erc721aUnit>();
        }


        public string Description { get; set; }
        public int TotalSupply { get; set; }
        public int TotalMinted { get; set; }
        public virtual ICollection<Erc721aUnit> Units { get; set; }
    }
}
