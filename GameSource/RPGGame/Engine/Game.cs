using System;
using System.Threading;
using RPG.Engine.Scripts.Characters.Items;
using RPG.Engine.Scripts.Characters.NonPlayable;

namespace RPG.Engine
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Account;
    using Graphics;
    using Scripts.Characters.Playable;
    using Scripts.Characters.Shared;
    using Scripts.Environment;
    using GameSystem.Controls;
    using GameSystem.CustomExceptions;
    using RPGGame;

    /// <summary>
    /// A class for the game
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Number of players
        /// </summary>
        private int numbersOfPlayers;

        /// <summary>
        /// Initializes a new instance of the Game class
        /// </summary>
        public Game()
        {
            this.Rooms = new List<Room>();
            this.Enemies = new List<Enemy>();
            this.Heroes = new List<Hero>();
            this.LootTable = new Dictionary<Coordinate, Item>();
        }

        public Dictionary<Coordinate, Item> LootTable { get; set; }

        public List<Enemy> Enemies { get; set; }

        /// <summary>
        /// Gets or sets the number of players.
        /// </summary>
        private int NumberOfPlayers
        {
            get
            {
                return numbersOfPlayers;
            }

            set
            {
                if (value < 1 && value > 2)
                {
                    throw new InvalidNumberOfPlayers();
                }

                numbersOfPlayers = value;
            }
        }
        private List<Hero> Heroes { get; set; }

        private List<Player> Players = new List<Player>();
        private List<Room> Rooms { get; set; }

        private List<Character> Characters { get; set; }

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

        public void GenerateRooms()
        {
            Room room = RoomFactory.Create();
            this.Rooms.Add(room);
        }

        public void GenerateHeroes()
        {
            if (numbersOfPlayers == 1)
            {
                Hero ivan = new Ivan(1, 1);
                this.Heroes.Add(ivan);
            }
            else if (this.NumberOfPlayers == 2)
            {
                Hero ivan = new Ivan(1, 1);
                Hero gosho = new Gosho(2, 2);
                this.Heroes.Add(ivan);
                this.Heroes.Add(gosho);
            }
        }

        public void AskForNumberOfPlayers()
        {
            GraphicalEngine.ClearScreen();
            Console.WriteLine("Enter number of players: ");

            this.NumberOfPlayers = int.Parse(Console.ReadLine());
        }

        public void SelectHeroes()
        {
            foreach (var player in this.Players)
            {
                // TODO Show screen with current heroes
                // TODO Player selects a hero from the available heroes
            }
        }

        /// <summary>
        /// Method to play the game
        /// </summary>
        public void Play()
        {
            GraphicalEngine.ClearScreen();
            GraphicalEngine.DrawRoom(this.Rooms[0]);
            GraphicalEngine.DrawCharacters(this.Heroes);
            GraphicalEngine.DrawCharacters(this.Enemies);

            while (true)
            {
                Input.GetInput(this.Heroes);
                
                HeroesLogic();
                EnemiesLogic();


                Thread.Sleep(100);
            }
        }

        public void EnemiesLogic()
        {
            GraphicalEngine.DrawEmpty(this.Enemies);

            // Loop through enemies
            for (int i = 0; i < this.Enemies.Count; i++)
            {
                if (this.Enemies[i].IsDead())
                {
                    Coordinate coordinate = new Coordinate(this.Enemies[i].LocationRow, this.Enemies[i].LocationColumn, 0);
                    Item item = this.Enemies[i].LootItem;
                    this.LootTable.Add(coordinate, item);
                    this.Enemies[i] = null;
                }
                else
                {
                    this.Enemies[i].Move();
                }
            }

            // Remove dead enemies
            this.Enemies.RemoveAll(null);

            GraphicalEngine.DrawCharacters(this.Enemies);
        }


        public void HeroesLogic()
        {
            GraphicalEngine.DrawEmpty(this.Heroes);

            // loop through heroes
            foreach (var hero in this.Heroes)
            {
                if (hero.IsDead())
                {
                    hero.Revive();
                }
                else
                {
                    hero.Move();
                }

                Coordinate coordinate = new Coordinate(hero.LocationRow, hero.LocationColumn, 0);
                if (this.LootTable.ContainsKey(coordinate))
                {
                    // TODO Looting
                }
            }

            GraphicalEngine.DrawCharacters(this.Heroes);
        }

        /// <summary>
        /// Method to show the intro screen
        /// </summary>
        public void ShowIntoScreen()
        {

        }

        /// <summary>
        /// Method to show the end screen
        /// </summary>
        public void ShowEndScreen()
        {

        }
    }
}
