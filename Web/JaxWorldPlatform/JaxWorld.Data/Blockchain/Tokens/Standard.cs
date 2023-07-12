namespace JaxWorld.Data.Blockchain.Tokens
{
    using Tokens.Base;

    public class Standard
    {
        public Standard()
        {
            ContractProfiles = new HashSet<ContractProfile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ContractProfile> ContractProfiles { get; set; }
    }
}
