using ChatGPTClone.Domain.Common;
using ChatGPTClone.Domain.Enums;
using ChatGPTClone.Domain.ValueObjects;

namespace ChatGPTClone.Domain.Entities
{
    public sealed class ChatSession : EntityBase
    {
        public string Title { get; set; }
        public GptModelType Model { get; set; }
        public List<ChatThread> Threads { get; set; } = [];
        public Guid AppUserId { get; set; }  
    }
}
