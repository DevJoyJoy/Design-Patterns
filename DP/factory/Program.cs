using SOFactory;

Dictionary<string, IFactory> options = new Dictionary<string, IFactory>
{
    { "windows", new WindowsFactory() },
    { "mac", new MacFactory() },
    { "linux", new LinuxFactory() }
};

var inputUser = Console.ReadLine();
var algo = new Application(options[inputUser]);
algo.Action();