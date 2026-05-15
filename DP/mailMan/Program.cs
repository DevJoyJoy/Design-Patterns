MailMan carteiro = new();

for (int i = 0; i < 17; i++)
    carteiro.em.Inscrever("Assassinato", new User());
for (int i = 0; i < 2; i ++)
    carteiro.em.Inscrever("Emprego", new User());

carteiro.Post("Assassinato");