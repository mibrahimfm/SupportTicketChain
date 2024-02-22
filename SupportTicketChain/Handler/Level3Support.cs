namespace SupportTicketChain.Handler
{
    internal class Level3Support : BaseHandler
    {
        public override void Handle(int ticket, int priority)
        {
            if (priority < 30)
                Console.WriteLine($"Level 3 support analyst handling ticket {ticket}");
            else
                base.Handle(ticket, priority);
        }
    }
}
