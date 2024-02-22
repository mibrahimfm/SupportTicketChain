namespace SupportTicketChain.Handler
{
    public class Level1Support : BaseHandler
    {
        public override void Handle(int ticket, int priority)
        {
            if (priority < 10)
                Console.WriteLine($"Level 1 support analyst handling ticket {ticket}");
            else
                base.Handle(ticket, priority);
        }
    }
}
