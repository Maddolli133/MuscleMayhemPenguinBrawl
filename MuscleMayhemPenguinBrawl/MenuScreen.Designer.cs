namespace MuscleMayhemPenguinBrawl
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
            this.menuTitleLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuTitleLabel
            // 
            this.menuTitleLabel.AutoSize = true;
            this.menuTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitleLabel.Location = new System.Drawing.Point(191, 33);
            this.menuTitleLabel.Name = "menuTitleLabel";
            this.menuTitleLabel.Size = new System.Drawing.Size(310, 84);
            this.menuTitleLabel.TabIndex = 0;
            this.menuTitleLabel.Text = "Muscle Mayhem: \r\nPenguin Brawl";
            this.menuTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(300, 198);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(75, 23);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(300, 272);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 2;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.menuTitleLabel);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(703, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuTitleLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button optionsButton;
    }
}
