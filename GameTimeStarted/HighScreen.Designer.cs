namespace GameTimeStarted
{
    partial class HighScreen
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
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.menuScreenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BackColor = System.Drawing.Color.SlateGray;
            this.highScoreLabel.Location = new System.Drawing.Point(450, 257);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(300, 335);
            this.highScoreLabel.TabIndex = 0;
            this.highScoreLabel.Text = "High Scores ";
            this.highScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuScreenButton
            // 
            this.menuScreenButton.Location = new System.Drawing.Point(511, 616);
            this.menuScreenButton.Name = "menuScreenButton";
            this.menuScreenButton.Size = new System.Drawing.Size(177, 46);
            this.menuScreenButton.TabIndex = 1;
            this.menuScreenButton.Text = "Menu";
            this.menuScreenButton.UseVisualStyleBackColor = true;
            this.menuScreenButton.Click += new System.EventHandler(this.menuScreenButton_Click);
            // 
            // HighScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.menuScreenButton);
            this.Controls.Add(this.highScoreLabel);
            this.Name = "HighScreen";
            this.Size = new System.Drawing.Size(1200, 900);
            this.Load += new System.EventHandler(this.HighScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Button menuScreenButton;
    }
}
