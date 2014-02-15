using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GameLoop.Properties;

namespace GameLoop
{
    class Level
    {
        // Level graphics
        private Bitmap mapBuffer;
        private Graphics mapGraphics;
        private readonly Font textFont = new Font("Consolas", 12, FontStyle.Bold);
        private readonly SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 255, 85));
     
        // Map
        private const int TILE_SIZE = 16;
        private const int MAP_WIDTH = 33;
        private const int MAP_HEIGHT = 19;
        private char[,] map;
        public Rectangle MapRectangle { get; private set; }
        public Size ClientSize { get; private set; }
        public int MapXoffset { get; private set; }
        public int MapYoffset { get; private set; }
        public int TextscreenHeight { get; private set; }

        // Resources
        private Bitmap bmpTileEmpty;
        private Bitmap bmpTileBlack;
        private Bitmap bmpTileWall;
        private Bitmap bmpPlayer;
        private Bitmap bmpWall;

        // Player vars
        private const int PLAYER_SPEED = 1;
        private enum Direction { Left, Right, Up, Down, Center }
        private Direction playerDirection;
        private int playerX;
        private int playerY;

        public Level()
        {
            MapXoffset = 20;
            MapYoffset = 20;
            TextscreenHeight = 40;

            MapRectangle = new Rectangle(0, 0, MAP_WIDTH * TILE_SIZE, MAP_HEIGHT * TILE_SIZE);
            ClientSize = new Size(MapRectangle.Width + 2 * MapXoffset, MapRectangle.Height + MapYoffset + TextscreenHeight);

            mapBuffer = new Bitmap(MapRectangle.Width, MapRectangle.Height);
            mapGraphics = Graphics.FromImage(mapBuffer);

            bmpPlayer = Resources.Tiles28x46Player;
            playerX = TILE_SIZE; // Put on empty tile!
            playerY = TILE_SIZE; // Put on empty tile!

            LoadMapFromFile();
            DrawMapToMemory();
        }

        public void Update(GameTime gameTime)
        {
            MovePlayer(gameTime);
        }

        public void Draw(GameTime gameTime, Graphics screenGraphics)
        {
            // Draw the walls to the map buffer
            mapGraphics.DrawImage(bmpWall, 0, 0, bmpWall.Width, bmpWall.Height);

            // Draw the player to the map buffer
            mapGraphics.DrawImage(bmpPlayer, playerX, playerY, bmpPlayer.Width, bmpPlayer.Height);

            // Clear the screen background (because it is larger than the map)
            screenGraphics.Clear(Color.Black);

            // Draw the map to the screenbuffer
            screenGraphics.DrawImage(mapBuffer, MapXoffset, MapYoffset, mapBuffer.Width, mapBuffer.Height);

            // Draw the text messages to the screenbuffer
            DrawMessages(gameTime, screenGraphics);
        }

        private void LoadMapFromFile()
        {
            // Load the level map.
            int levelIndex = 0;
            string levelPath = string.Format(@"...\...\Level{0}.txt", levelIndex);

            // Load the map and ensure all of the lines are the same length.
            int width;
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(levelPath))
            {
                string line = reader.ReadLine();
                width = line.Length;
                while (line != null)
                {
                    lines.Add(line);
                    if (line.Length != width)
                        throw new Exception(String.Format("The length of line {0} is different from all preceeding lines.", lines.Count));
                    line = reader.ReadLine();
                }
            }

            // Allocate the tile grid.
            map = new char[lines.Count, width];
            for (int row = 0; row < map.GetLength(0); ++row)
            {
                for (int col = 0; col < map.GetLength(1); ++col)
                {
                    char tileType = lines[row][col];
                    map[row, col] = tileType;
                }
            }

            // Verify that the level has a beginning and an end.
        }

        private void DrawMapToMemory()
        {
            bmpTileEmpty = Resources.Tile16x16Empty;
            bmpTileWall = Resources.Tile16x16Wall;
            bmpTileBlack = Resources.Tile16x16Black;

            this.bmpWall = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            Graphics mapGraphics = Graphics.FromImage(this.bmpWall);

            Bitmap tile;
            Rectangle rect;
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    int x = col * 16;
                    int y = row * 16;
                    rect = new Rectangle(x, y, bmpTileEmpty.Width, bmpTileEmpty.Height);
                    switch (map[row, col])
                    {
                        case '.':
                            tile = bmpTileBlack;
                            break;
                        case 'W':
                            tile = bmpTileWall;
                            break;
                        default:
                            tile = bmpTileEmpty;
                            break;
                    }
                    mapGraphics.DrawImage(tile, rect);
                }
            }
        }

        private void DrawMessages(GameTime gameTime, Graphics g)
        {
            // Draw the text messages (first line) to the screenbuffer
            string line0 = string.Format("LEVEL 1");
            g.DrawString(line0, textFont, textBrush, CenterTextX(line0), 0);

            // Draw the text messages (second line) to the screenbuffer
            string line1 = string.Format("Use the arrow keys to move around...");
            g.DrawString(line1, textFont, textBrush, CenterTextX(line1), MapYoffset + this.MapRectangle.Bottom);

            // Draw the text messages (third line) to the screenbuffer
            //string line2 = string.Format("Player tile: ({0}, {1})", playerX / TILE_SIZE, playerY / TILE_SIZE);
            string line2 = string.Format("fps: {0:F1}", 1000 / gameTime.ElapsedTime.TotalMilliseconds);
            
            g.DrawString(line2, textFont, textBrush, CenterTextX(line2), MapYoffset + this.MapRectangle.Bottom + 20);
        }

        private bool ValidateXY(int x, int y)
        {
            return x >= 0 && x <= MapRectangle.Width - bmpPlayer.Width && y >= 0 && y <= MapRectangle.Height - bmpPlayer.Height;
        }

        private bool CheckWallCollision(Bitmap bmpPlayer)
        {
            // Get the player's bounding rectangle and find neighboring tiles.
            Rectangle bounds = new Rectangle(playerX, playerY, bmpPlayer.Width, bmpPlayer.Height);
            int leftTile = bounds.Left / TILE_SIZE;
            int rightTile = (int)Math.Ceiling(((float)bounds.Right / TILE_SIZE));
            int topTile = bounds.Top / TILE_SIZE;
            int bottomTile = (int)Math.Ceiling(((float)bounds.Bottom / TILE_SIZE));

            for (int row = topTile; row < bottomTile; row++)
            {
                for (int col = leftTile; col < rightTile; col++)
                {
                    if (map[row, col] == 'W')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Returns the X coord of the text so that it is centered on the screen
        /// </summary>
        private int CenterTextX(string text)
        {
            if (text.Length * 9 > this.ClientSize.Width)
            {
                return 0;
            }
            return (this.ClientSize.Width - text.Length * 9) / 2;
        }

        public void OnKeyDown(Keys key)
        {
            if (key == Keys.Left)
            {
                playerDirection = Direction.Left;
            }
            else if (key == Keys.Right)
            {
                playerDirection = Direction.Right;
            }
            else if (key == Keys.Up)
            {
                playerDirection = Direction.Up;
            }
            else if (key == Keys.Down)
            {
                playerDirection = Direction.Down;
            }
        }

        internal void OnKeyUp()
        {
            playerDirection = Direction.Center;
        }

        public void MovePlayer(GameTime gameTime)
        {
            if (playerDirection == Direction.Center)
            {
                return;
            }

            int temp_x = playerX;
            int temp_y = playerY;

            double step = PLAYER_SPEED * gameTime.ElapsedTime.TotalMilliseconds;

            if (playerDirection == Direction.Left)
            {
                playerX -= PLAYER_SPEED;
            }
            else if (playerDirection == Direction.Right)
            {
                playerX += PLAYER_SPEED;
            }
            else if (playerDirection == Direction.Up)
            {
                playerY -= PLAYER_SPEED;
            }
            else if (playerDirection == Direction.Down)
            {
                playerY += PLAYER_SPEED;
            }

            if (ValidateXY(playerX, playerY) && CheckWallCollision(bmpPlayer))
            {
                // Player was moved
                return;
            }

            // Player cannot go here, return the old coords
            playerX = temp_x;
            playerY = temp_y;
        }
    }
}