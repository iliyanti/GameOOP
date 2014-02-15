namespace GameLoop
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class GameForm : Form
    {
        private readonly Bitmap screenBuffer;
        private readonly Graphics screenGraphics;
        private Level level;
        private FastLoop fastLoop;

        public GameForm()
        {
            InitializeForm();

            // Create level
            this.level = new Level();

            // Set client size
            this.ClientSize = level.ClientSize;

            screenBuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            screenGraphics = Graphics.FromImage(screenBuffer);

            fastLoop = new FastLoop(GameLoop);
        }

        void GameLoop(GameTime gameTime)
        {
            // GameCode goes here
            // GetInput
            // Process
            // Render
            System.Console.WriteLine(gameTime.ElapsedTime.TotalMilliseconds);
            Sleep(40);

            // Redraw the Form window
            Invalidate();
        }

        void Sleep(long someTime)
        {
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < someTime)
            {
                // This cycle will take someTime to complete
            }
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            level.Draw(screenGraphics);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Redraw the form (raises OnPaint event) 
            Invalidate();
        }

        private void InitializeForm()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.Black;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
        }
    }
}