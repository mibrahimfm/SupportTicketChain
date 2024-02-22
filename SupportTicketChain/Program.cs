using SupportTicketChain.Handler;

IHandler handler1 = new Level1Support();
IHandler handler2 = new Level2Support();
IHandler handler3 = new Level3Support();

handler2.SetSuccessor(handler3);
handler1.SetSuccessor(handler2);

handler1.Handle(1, 15);
handler1.Handle(2, 6);
handler1.Handle(3, 24);
handler1.Handle(4, 35);