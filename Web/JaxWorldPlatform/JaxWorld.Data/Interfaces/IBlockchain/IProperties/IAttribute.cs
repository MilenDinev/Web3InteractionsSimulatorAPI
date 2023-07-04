namespace JaxWorld.Data.Interfaces.IBlockchain.IProperties
{
    public interface IAttribute
    {
        int ContractId { get; set; }
        string Type { get; set; }
        string Value { get; set; }
    }
}
