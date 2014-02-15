using System;
using System.Drawing;
using System.Windows.Forms;

namespace Wolf
{
    public partial class GameForm : Form
    {
        private readonly Bitmap screenBuffer;
        private readonly Graphics screenGraphics;
        private Level level;

        public GameForm()
        {
            // Required by Windows
            InitializeComponent();

            // Create level
            this.level = new Level();

            // Set client size
            this.ClientSize = level.ClientSize;

            screenBuffer = new Bitmap(ClientSize.Width, ClientSize.Height);
            screenGraphics = Graphics.FromImage(screenBuffer);
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
    }
}