namespace animatedgame
{
    partial class MenuScreen
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
            this.Playbutton = new System.Windows.Forms.Button();
            this.playLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playbutton
            // 
            this.Playbutton.Location = new System.Drawing.Point(128, 168);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(297, 134);
            this.Playbutton.TabIndex = 0;
            this.Playbutton.Text = "PLAY";
            this.Playbutton.UseVisualStyleBackColor = true;
            this.Playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLabel.Location = new System.Drawing.Point(215, 62);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(127, 29);
            this.playLabel.TabIndex = 1;
            this.playLabel.Text = "GROW.IO";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.Playbutton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(589, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playbutton;
        private System.Windows.Forms.Label playLabel;
    }
}
