namespace JaxWorld.Data.Blockchain.Properties
{
    using Interfaces.IBlockchain.IProperties;

    public class Utility : IUtility
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
    }
}
