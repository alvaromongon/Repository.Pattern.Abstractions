namespace Repository.Pattern.Abstractions
{
    public interface IDomainModel
    {
        string PartitionKey { get; }
        string RowKey { get; }
    }
}
