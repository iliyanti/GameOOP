namespace GameLoop
{
    using System.Drawing;
    using GameLoop.Properties;

    public enum Direction { Left, Right, Up, Down, Center }

    public class Player
    {
        private const int PLAYER_SPEED = 1;
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