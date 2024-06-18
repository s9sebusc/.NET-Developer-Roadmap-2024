// Die Kette erstellen
using ChainOfResponsibility;

ISupportHandler level1Support = new Level1Support();
ISupportHandler level2Support = new Level2Support();
ISupportHandler level3Support = new Level3Support();

level1Support.SelectNextStep(level2Support);
level2Support.SelectNextStep(level3Support);

Ticket bug = new Ticket(12345, Priority.Critical);
level1Support.HandleTicket(bug);

Ticket feature = new Ticket(99999, Priority.Medium);
level1Support.HandleTicket(feature);


