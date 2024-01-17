using tdd_oop_concrete_dependency_injection.CSharp.Main;

PowerSupply myPsu = new PowerSupply();
List<Game> preInstalled = new List<Game>();
Computer myPc = new Computer(myPsu, preInstalled);

//myPc.installGame("Final Fantasy XI");


preInstalled.Add(new Game("Dwarf Fortress"));
preInstalled.Add(new Game("Baldur's Gate"));
Console.WriteLine("");