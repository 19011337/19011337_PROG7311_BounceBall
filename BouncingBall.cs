#region File Header

// //---------------------------------------------------------------------------------------------------------------------//
// // User Name: 
// // File Name :BouncingBall.cs
// // Date :2019 / 04 / 23 / 11:47
// // File Data: 2018 / 10 / 18
// //---------------------------------------------------------------------------------------------------------------------//

#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;


namespace IliumManager.Components
{
    public partial class BouncingBall : UserControl
    {
        // Some drawing parameters.
        private const int BallWidth = 20;
        private const int BallHeight = 20;

        private readonly Random RandomNumber = new Random(255);

        private Brush BallColor = Brushes.DodgerBlue;
        private int BallVx, BallVy; // Velocity.
        private int BallX, BallY;   // Position.

        //----------------------------------------------------------------------------------------------------------------//
        public BouncingBall()
        {
            this.InitializeComponent();
            this.Init();
        }

        //----------------------------------------------------------------------------------------------------------------//
        /// <summary>
        ///     Init Form
        /// </summary>
        private void Init()
        {
            this.tmrBall.Enabled = false;
            this.Visible = false;
            // Pick a random start position and velocity.
            var rnd = new Random();
            this.BallVx = rnd.Next(1, 2);
            this.BallVy = rnd.Next(1, 4);
            this.BallX = rnd.Next(0, this.ClientSize.Width - BallWidth);
            this.BallY = rnd.Next(0, this.ClientSize.Height - BallHeight);

            // Use double buffering to reduce flicker.
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            this.UpdateStyles();
        }

        //----------------------------------------------------------------------------------------------------------------//
        /// <summary>
        ///     Timer Tick Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrBall_Tick(object sender, EventArgs e)
        {
            this.Tick();
        }

        //----------------------------------------------------------------------------------------------------------------//
        /// <summary>
        ///     Paint event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BouncingBall_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            e.Graphics.FillEllipse(this.BallColor, this.BallX, this.BallY, BallWidth, BallHeight);
            e.Graphics.DrawEllipse(Pens.Black, this.BallX, this.BallY, BallWidth, BallHeight);
        }

        //----------------------------------------------------------------------------------------------------------------//
        /// <summary>
        ///     To Process Ticks
        /// </summary>
        private void Tick()
        {
            this.BallX += this.BallVx;
            if (this.BallX < 0)
            {
                this.BallVx = -this.BallVx;
                Boing();
            }
            else if (this.BallX + BallWidth > this.ClientSize.Width)
            {
                this.BallVx = -this.BallVx;
                Boing();
            }

            this.BallY += this.BallVy;
            if (this.BallY < 0)
            {
                this.BallVy = -this.BallVy;
                Boing();
            }
            else if (this.BallY + BallHeight > this.ClientSize.Height)
            {
                this.BallVy = -this.BallVy;
                Boing();
            }

            this.Refresh();
        }

        //----------------------------------------------------------------------------------------------------------------//
        /// <summary>
        ///     Play the boing sound file resource.
        /// </summary>
        private void Boing()
        {
            using (var player = new SoundPlayer(BounceBall.Properties.Resources.boing))

            {
                player.Play();
                //return;
                var color = Color.FromArgb((byte) this.RandomNumber.Next(), (byte) this.RandomNumber.Next(), (byte)this.RandomNumber.Next());
                this.BallColor = new SolidBrush(color);
            }
        }

        //----------------------------------------------------------------------------------------------------------------//
        /// <summary>
        ///     Method Sets the Ball In Motion...
        /// </summary>
        /// <param name="startStop"></param>
        public void StartStop(bool startStop)
        {
            this.tmrBall.Enabled = startStop;
            this.Visible = startStop;
        }

        //----------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates the Speed of the Ball
        /// </summary>
        /// <param name="speedValueIn"></param>
        public void BounceBallSpeed(int speedValueIn)
        {
            this.tmrBall.Interval = speedValueIn;
        }
    }
}
//------------------------------------------...ooo000 END OF FILE 000ooo...-------------------------------------------------//