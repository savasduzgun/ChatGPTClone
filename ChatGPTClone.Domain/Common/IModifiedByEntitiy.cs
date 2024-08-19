namespace ChatGPTClone.Domain.Common
{
    public interface IModifiedByEntitiy
    {
        DateTimeOffset? ModifiedOn { get; set; }
        string? ModifiedByUserId { get; set; }
    }
}
