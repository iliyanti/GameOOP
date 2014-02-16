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

        public PointF position;
        private Point mapPosition;
        public Direction playerDirection;

        public Player(int x, int y)
        {
            bmpPlayer = Resources.Tiles28x46Player;
            position = new PointF(x, y);
            mapPosition = new Point((int)Math.Round(position.X), (int)Math.Round(position.Y));
        }

        public void Move(GameTime gameTime)
        {
            if (playerDirection == Direction.Center)
            {
                return;
            }

            PointF temp_position = position;
            Point temp_mapPos = mapPosition;

            float move = (float)(PlayerSpeed * gameTime.ElapsedTime.TotalMilliseconds);

            if (playerDirection == Direction.Left)
            {
                position.X -= move;
            }
            else if (playerDirection == Direction.Right)
            {
                position.X += move;
            }
            else if (playerDirection == Direction.Up)
            {
                position.Y -= move;
            }
            else if (playerDirection == Direction.Down)
            {
                position.Y += move;
            }

            mapPosition = new Point((int)Math.Round(position.X), (int)Math.Round(position.Y));

            Rectangle bounds = new Rectangle(mapPosition.X, mapPosition.Y, bmpPlayer.Width, bmpPlayer.Height);

            if (Collisions.ValidateXY(bounds) && Collisions.CheckWallCollision(bounds))
            {
                // Player was moved
                return;
            }

            // Player cannot go here, return the old coords
            position = temp_position;
            mapPosition = temp_mapPos;
        }

        public void Draw(GameTime gameTime, Graphics mapGraphics)
        {
            // Draw the player to the map buffer
            mapGraphics.DrawImage(bmpPlayer, mapPosition.X, mapPosition.Y, bmpPlayer.Width, bmpPlayer.Height);
        }
    }
}