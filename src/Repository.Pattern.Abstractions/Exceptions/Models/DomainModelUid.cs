namespace Repository.Pattern.Abstractions.Exceptions.Models
{
    public class DomainModelUid
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }
}
