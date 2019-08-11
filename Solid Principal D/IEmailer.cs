namespace Solid_Principal_D
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string msg);
    }
}