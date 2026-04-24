using Robo;

var Robozinho = new Robozin("Wallie", new WalkRobo());

for (int i = 0; i < 21; i++)
{
    Console.WriteLine(Robozinho.Nome + " disse: " + Robozinho.Act());
    Thread.Sleep(100);
}    