namespace IliumManager.Components
{
    partial class BouncingBall
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrBall = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrBall
            // 
            this.tmrBall.Tick += new System.EventHandler(this.TmrBall_Tick);
            // 
            // BouncingBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "BouncingBall";
            this.Size = new System.Drawing.Size(970, 79);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BouncingBall_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrBall;
    }
}
