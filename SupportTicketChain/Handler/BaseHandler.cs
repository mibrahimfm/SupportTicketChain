namespace SupportTicketChain.Handler
{
    public class BaseHandler : IHandler
    {
        private IHandler _successor;

        public void SetSuccessor(IHandler successor)
        {
            _successor = successor;
        }

        public virtual void Handle(int ticket, int priority)
        {
            if (_successor != null)
                _successor.Handle(ticket, priority);
            else
                Console.WriteLine($"No support analyst capable of handling ticket {ticket}");
        }
    }
}
