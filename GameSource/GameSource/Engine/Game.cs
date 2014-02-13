using System.Collections.Generic;
using Name.Engine.Scripts.Characters.NonPlayer;
using Name.Engine.Scripts.Characters.Player;
using Name.Engine.Scripts.Environment;

namespace Name.Engine
{
    public class Game
    {
        public Game()
        {
            this.Rooms = new List<Room>();
            this.Heroes = new List<Hero>();
            this.Enemies = new List<Enemy>();
        }
        public List<Room> Rooms { get; set; }

        public List<Hero> Heroes { get; set; }

        public List<Enemy> Enemies { get; set; }

        public void CreatePlayer()
        {
            
        }

        public void Play()
        {
            while (true)
            {

                foreach (var hero in this.Heroes)
                {
                    hero.CheckHealth();
                    hero.Move();
                }

                foreach (var enemy in this.Enemies)
                {
                    enemy.Move();
                }

                
            }
        }
   
    }


    
}
