namespace SupportTicketChain.Handler
{
    public interface IHandler
    {
        public void SetSuccessor(IHandler successor);
        public void Handle(int ticket, int priority);
    }
}
