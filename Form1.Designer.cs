
namespace BounceBall
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.bouncingBall1 = new IliumManager.Components.BouncingBall();
            this.chkbOnOff = new System.Windows.Forms.CheckBox();
            this.numUpDownBounceBallSpeed = new System.Windows.Forms.NumericUpDown();
            this.chkbTick = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBounceBallSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.TmrMain_Tick);
            // 
            // bouncingBall1
            // 
            this.bouncingBall1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bouncingBall1.BackColor = System.Drawing.Color.White;
            this.bouncingBall1.Location = new System.Drawing.Point(0, 0);
            this.bouncingBall1.Name = "bouncingBall1";
            this.bouncingBall1.Size = new System.Drawing.Size(800, 411);
            this.bouncingBall1.TabIndex = 0;
            this.bouncingBall1.Visible = false;
            // 
            // chkbOnOff
            // 
            this.chkbOnOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbOnOff.AutoSize = true;
            this.chkbOnOff.BackColor = System.Drawing.Color.Transparent;
            this.chkbOnOff.Location = new System.Drawing.Point(13, 421);
            this.chkbOnOff.Name = "chkbOnOff";
            this.chkbOnOff.Size = new System.Drawing.Size(15, 14);
            this.chkbOnOff.TabIndex = 1;
            this.chkbOnOff.UseVisualStyleBackColor = false;
            this.chkbOnOff.Click += new System.EventHandler(this.ChkbOnOff_Click);
            // 
            // numUpDownBounceBallSpeed
            // 
            this.numUpDownBounceBallSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDownBounceBallSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownBounceBallSpeed.Location = new System.Drawing.Point(710, 417);
            this.numUpDownBounceBallSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownBounceBallSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownBounceBallSpeed.Name = "numUpDownBounceBallSpeed";
            this.numUpDownBounceBallSpeed.Size = new System.Drawing.Size(78, 26);
            this.numUpDownBounceBallSpeed.TabIndex = 2;
            this.numUpDownBounceBallSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownBounceBallSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownBounceBallSpeed.ValueChanged += new System.EventHandler(this.NumUpDownBounceBallSpeed_ValueChanged);
            // 
            // chkbTick
            // 
            this.chkbTick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkbTick.AutoSize = true;
            this.chkbTick.BackColor = System.Drawing.Color.Transparent;
            this.chkbTick.Location = new System.Drawing.Point(34, 421);
            this.chkbTick.Name = "chkbTick";
            this.chkbTick.Size = new System.Drawing.Size(15, 14);
            this.chkbTick.TabIndex = 3;
            this.chkbTick.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BounceBall.Properties.Resources._20140509_081355_Android;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkbTick);
            this.Controls.Add(this.numUpDownBounceBallSpeed);
            this.Controls.Add(this.chkbOnOff);
            this.Controls.Add(this.bouncingBall1);
            this.Name = "FormMain";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownBounceBallSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain;
        private IliumManager.Components.BouncingBall bouncingBall1;
        private System.Windows.Forms.CheckBox chkbOnOff;
        private System.Windows.Forms.NumericUpDown numUpDownBounceBallSpeed;
        private System.Windows.Forms.CheckBox chkbTick;
    }
}

