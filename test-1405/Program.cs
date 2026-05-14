Guilda guilda = new();

for (int i = 0; i < 5; i++)
    guilda.em.AddAdventure("Mage", new Mage(40, 60));
for (int i = 0; i < 5; i++)
    guilda.em.AddAdventure("Tank", new Tank(100, 15));
for (int i = 0; i < 5; i++)
    guilda.em.AddAdventure("Warrior", new Warrior(60, 30));

guilda.em.CreateBoss("Boss", new Boss(800, Random.Shared.Next(0, 31)));
guilda.em.CreateBoss("Angry Boss", new Boss(800, Random.Shared.Next(0, 61)));