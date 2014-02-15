namespace GameLoop
{
    using System;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Message
    {
        public IntPtr hWnd;
        public Int32 msg;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public System.Drawing.Point p;
    }

    public class FastLoop
    {
        public delegate void LoopCallback(GameTime gameTime);
        LoopCallback callback;
        GameTime gameTime;

        public FastLoop(LoopCallback callback)
        {
            this.callback = callback;
            Application.Idle += new EventHandler(OnApplicationEnterIdle);
            gameTime = new GameTime();
        }

        void OnApplicationEnterIdle(object sender, EventArgs e)
        {
            while (IsAppStillIdle())
            {
                callback(gameTime);
            }
        }

        private bool IsAppStillIdle()
        {
            Message msg;
            return !PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
        }

        [System.Security.SuppressUnmanagedCodeSecurity]
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool PeekMessage(
        out Message msg,
        IntPtr hWnd,
        uint messageFilterMin,
        uint messageFilterMax,
        uint flags);
    }
}