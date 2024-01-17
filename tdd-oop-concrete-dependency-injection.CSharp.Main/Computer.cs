using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tdd_oop_concrete_dependency_injection.CSharp.Main
{
    //Refactor the classes so that you are passing in instances of the Game class rather than instantiating them inside the Computer class,
    //modify any corresponding tests to make them work. Create a new branch for this.
    //Refactor the classes and any tests that use them so that they exhibit encapsulation and abstraction more fully.
    public class Computer 
    {
        public List<Game> installedGames = new List<Game>();

        public PowerSupply powerSupply;

        public Computer(PowerSupply powerSupply) {
            this.powerSupply = powerSupply;
        }
        public Computer(PowerSupply powerSupply, List<Game> preInstalled)
        {
            this.powerSupply = powerSupply;
            foreach (var game in preInstalled)
            {
                this.installedGames.Add(game);
            }
        }

        public void turnOn() {
            powerSupply.turnOn();
        }

        public void installGame(Game game) {
            this.installedGames.Add(game);
        }

        public string playGame(string name) {
            foreach (Game g in this.installedGames) {
                if (g.name.Equals(name)) {
                    return g.start();
                }
            }
            return "Game not installed";
        }
    }
}
