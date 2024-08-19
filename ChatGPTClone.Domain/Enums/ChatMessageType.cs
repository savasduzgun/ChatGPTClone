namespace ChatGPTClone.Domain.Enums
{
    public enum ChatMessageType
    {
        // The prompt which is sent to the GPT model
        System = 1,

        // The mesaage which is sent by the user
        User = 2,

        // The mesaage which is sent by the assistant
        Assistant = 3,
    }
}
