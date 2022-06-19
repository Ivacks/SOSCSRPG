using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Ivan";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.CharacterClass = "Wizard";
            CurrentPlayer.Level = 1;
            CurrentPlayer.ExperiencePoints = 0;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(2, 0);
        }
    }
}
