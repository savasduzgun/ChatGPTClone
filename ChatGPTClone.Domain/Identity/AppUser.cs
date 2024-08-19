using ChatGPTClone.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace ChatGPTClone.Domain.Identity
{
    public class AppUser : IdentityUser<Guid>, IEntity, ICreatedByEntity, IModifiedByEntitiy
    {
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public string? ModifiedByUserId { get; set; }
    }
}
