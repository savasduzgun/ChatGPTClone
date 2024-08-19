namespace ChatGPTClone.Domain.ValueObjects
{
    public class ChatThread
    {
        public string Id { get; set; }
        public List<ChatMessage> Messages { get; set; } = []; /*= new List<ChatMessage>();*/
        public DateTimeOffset CreatedOn { get; set; }
    }
}
