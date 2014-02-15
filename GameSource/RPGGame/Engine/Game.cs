using System.Collections.Generic;
using System.Windows.Forms;
using RPGGame.Account;
using RPGGame.Engine.Scripts.Characters.NonPlayable;
using RPGGame.Engine.Scripts.Characters.Playable;
using RPGGame.Engine.Scripts.Environment;

namespace RPGGame.Engine
{
    public class Game
    {
        private int numbersOfPlayers;

        public int NumberOfPlayers
        {
            get { return numbersOfPlayers; }
            set { numbersOfPlayers = value; }
        }

        public Game()
        {
            this.Rooms = new List<Room>();
            this.Heroes = new List<Hero>();
            this.Enemies = new List<Enemy>();
        }


        public List<Player> Players = new List<Player>();
        public List<Room> Rooms { get; set; }

        public List<Hero> Heroes { get; set; }

        public List<Enemy> Enemies { get; set; }

        public void SaveExisitingPlayers()
        {
            // TODO Save player data to a file
        }
        public void LoadExisitngPlayers()
        {
            // TODO Load player data from a file
        }

        public void ShowLoginScreen()
        {
           Application.Run(new LoginScreen());

        }

        public void AskForNumberOfPlayers()
        {

            // TODO Graphical - Ask for number of players
            // TODO Fix this function.
            this.NumberOfPlayers = 1;
        }

        public void SelectHeroes()
        {
            foreach (var player in this.Players)
            {
                // TODO Show screen with current heroes
                // TODO Player selects a hero from the available heroes
            }
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
