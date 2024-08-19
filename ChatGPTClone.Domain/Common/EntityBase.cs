namespace ChatGPTClone.Domain.Common
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string? ModifiedByUserId { get; set; }

    }
}
