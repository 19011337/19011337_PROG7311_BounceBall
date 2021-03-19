using IliumManager.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BounceBall
{
    public partial class FormMain : Form
    {
        //------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        ///   Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Timer Update Date And Time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrMain_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.TimeOfDay + " " + DateTime.Now.ToLongDateString();
        }

        //------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// BounceBall On Off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkbOnOff_Click(object sender, EventArgs e)
        {
            this.bouncingBall1.StartStop(this.chkbOnOff.Checked);
        }

        //------------------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates the Speed of the BounceBall
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumUpDownBounceBallSpeed_ValueChanged(object sender, EventArgs e)
        {
            this.bouncingBall1.BounceBallSpeed((int)this.numUpDownBounceBallSpeed.Value);
        }
    }
}
///---------------------------------------------...ooo000 END OF FILE 000ooo...--------------------------------------------//
