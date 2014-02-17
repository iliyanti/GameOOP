﻿using System.Collections.Generic;
using System.Windows.Forms;
using RPG.Account;
using RPG.Engine.Graphics;
using RPG.Engine.Scripts.Characters.Playable;
using RPG.Engine.Scripts.Characters.Shared;
using RPG.Engine.Scripts.Environment;
using RPG.GameSystem.Controls;
using RPG.GameSystem.CustomExceptions;
using RPGGame;

namespace RPG.Engine
{
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
            this.Characters = new List<Character>();
            this.Heroes = new List<Hero>();
        }

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


        public void AskForNumberOfPlayers()
        {
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

        /// <summary>
        /// Method to play the game
        /// </summary>
        public void Play()
        {
            GraphicalEngine.DrawRoom(this.Rooms[0]);
            GraphicalEngine.DrawCharacters(this.Characters);
            while (true)
            {
                Input.GetInput(this.Heroes);

                GraphicalEngine.DrawEmpty(this.Characters);
                foreach (var character in this.Characters)
                {
                    character.CheckHealth();
                    character.Move();
                }

                GraphicalEngine.DrawCharacters(this.Characters);
            }
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
