namespace Game
{
    using System.Drawing;
    using Game.Properties;
    using System;

    public enum Direction { Left, Right, Up, Down, Center }

    public class Player
    {
        // Player speed in pixels per millisecond
        private const float PlayerSpeed = 0.1f;
        public Bitmap bmpPlayer;

        public int playerX;
        public int playerY;
        public Direction playerDirection;

        public Player(int x, int y)
        {
            bmpPlayer = Resources.Tiles28x46Player;
            playerX = x;
            playerY = y;
        }

        public void Move(GameTime gameTime)
        {
            if (playerDirection == Direction.Center)
            {
                return;
            }

            int temp_x = playerX;
            int temp_y = playerY;

            int move = (int)Math.Round(PlayerSpeed * gameTime.ElapsedTime.TotalMilliseconds);

            if (playerDirection == Direction.Left)
            {
                playerX -= move;
            }
            else if (playerDirection == Direction.Right)
            {
                playerX += move;
            }
            else if (playerDirection == Direction.Up)
            {
                playerY -= move;
            }
            else if (playerDirection == Direction.Down)
            {
                playerY += move;
            }

            Rectangle bounds = new Rectangle(playerX, playerY, bmpPlayer.Width, bmpPlayer.Height);

            if (Collisions.ValidateXY(bounds) && Collisions.CheckWallCollision(bounds))
            {
                // Player was moved
                return;
            }

            // Player cannot go here, return the old coords
            playerX = temp_x;
            playerY = temp_y;
        }

        public void Draw(GameTime gameTime, Graphics mapGraphics)
        {
            // Draw the player to the map buffer
            mapGraphics.DrawImage(bmpPlayer, playerX, playerY, bmpPlayer.Width, bmpPlayer.Height);
        }
    }
}