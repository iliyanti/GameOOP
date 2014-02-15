namespace GameLoop
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class GameForm : Form
    {
        private readonly Bitmap screenBuffer;
        private readonly Graphics screenGraphics;
        private readonly FastLoop fastLoop;

        private Level level;

        public GameForm()
        {
            // Prepare the form
            InitializeForm();

            // Create level
            this.level = new Level();

            // Set client size
            this.ClientSize = level.ClientSize;

            // Set the graphics device
            screenBuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            screenGraphics = Graphics.FromImage(screenBuffer);

            // Runs the game loop whenever the application is idle
            fastLoop = new FastLoop(GameLoop);
        }

        void GameLoop(GameTime gameTime)
        {
            // This is the main game loop
            level.Update(gameTime);
            level.Draw(gameTime, screenGraphics);

            System.Console.WriteLine("fps: {0:F1}", 1000 / gameTime.ElapsedTime.TotalMilliseconds);

            // Redraw the Form window
            Invalidate();
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            // Render the screenbuffer to the screen
            e.Graphics.DrawImage(screenBuffer, 0, 0, screenBuffer.Width, screenBuffer.Height);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            //Don't allow the background to paint when using e.Graphics.DrawImage
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            level.OnKeyDown(e.KeyCode);
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            level.OnKeyUp();
        }

        private void InitializeForm()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.Black;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
        }
    }
}