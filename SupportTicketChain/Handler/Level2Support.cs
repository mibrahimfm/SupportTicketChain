namespace SupportTicketChain.Handler
{
    internal class Level2Support : BaseHandler
    {
        public override void Handle(int ticket, int priority)
        {
            if (priority < 20)
                Console.WriteLine($"Level 2 support analyst handling ticket {ticket}");
            else
                base.Handle(ticket, priority);
        }
    }
}
