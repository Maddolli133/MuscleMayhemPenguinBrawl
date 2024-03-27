namespace MuscleMayhemPenguinBrawl
{
    partial class ChestArea
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
            this.coinLabel = new System.Windows.Forms.Label();
            this.backPointsLabel = new System.Windows.Forms.Label();
            this.legPointsLabel = new System.Windows.Forms.Label();
            this.chestPointsLabel = new System.Windows.Forms.Label();
            this.armPointsLabel = new System.Windows.Forms.Label();
            this.chestLiftButton = new System.Windows.Forms.Button();
            this.skillButton = new System.Windows.Forms.Button();
            this.areaLegsButton = new System.Windows.Forms.Button();
            this.chestWeightUpButton = new System.Windows.Forms.Button();
            this.armAreaButton = new System.Windows.Forms.Button();
            this.chestGameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.BackColor = System.Drawing.Color.White;
            this.coinLabel.Location = new System.Drawing.Point(592, 41);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(13, 13);
            this.coinLabel.TabIndex = 11;
            this.coinLabel.Text = "0";
            // 
            // backPointsLabel
            // 
            this.backPointsLabel.AutoSize = true;
            this.backPointsLabel.BackColor = System.Drawing.Color.White;
            this.backPointsLabel.Location = new System.Drawing.Point(592, 105);
            this.backPointsLabel.Name = "backPointsLabel";
            this.backPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.backPointsLabel.TabIndex = 12;
            this.backPointsLabel.Text = "0";
            // 
            // legPointsLabel
            // 
            this.legPointsLabel.AutoSize = true;
            this.legPointsLabel.BackColor = System.Drawing.Color.White;
            this.legPointsLabel.Location = new System.Drawing.Point(592, 92);
            this.legPointsLabel.Name = "legPointsLabel";
            this.legPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.legPointsLabel.TabIndex = 13;
            this.legPointsLabel.Text = "0";
            // 
            // chestPointsLabel
            // 
            this.chestPointsLabel.AutoSize = true;
            this.chestPointsLabel.BackColor = System.Drawing.Color.White;
            this.chestPointsLabel.Location = new System.Drawing.Point(592, 79);
            this.chestPointsLabel.Name = "chestPointsLabel";
            this.chestPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.chestPointsLabel.TabIndex = 14;
            this.chestPointsLabel.Text = "0";
            // 
            // armPointsLabel
            // 
            this.armPointsLabel.AutoSize = true;
            this.armPointsLabel.BackColor = System.Drawing.Color.White;
            this.armPointsLabel.Location = new System.Drawing.Point(592, 66);
            this.armPointsLabel.Name = "armPointsLabel";
            this.armPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.armPointsLabel.TabIndex = 15;
            this.armPointsLabel.Text = "0";
            // 
            // chestLiftButton
            // 
            this.chestLiftButton.Location = new System.Drawing.Point(278, 357);
            this.chestLiftButton.Name = "chestLiftButton";
            this.chestLiftButton.Size = new System.Drawing.Size(110, 55);
            this.chestLiftButton.TabIndex = 10;
            this.chestLiftButton.Text = "Lift";
            this.chestLiftButton.UseVisualStyleBackColor = true;
            this.chestLiftButton.Click += new System.EventHandler(this.chestLiftButton_Click);
            // 
            // skillButton
            // 
            this.skillButton.Location = new System.Drawing.Point(595, 357);
            this.skillButton.Name = "skillButton";
            this.skillButton.Size = new System.Drawing.Size(98, 55);
            this.skillButton.TabIndex = 9;
            this.skillButton.Text = "Skill Upgrade";
            this.skillButton.UseVisualStyleBackColor = true;
            this.skillButton.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // areaLegsButton
            // 
            this.areaLegsButton.Location = new System.Drawing.Point(595, 179);
            this.areaLegsButton.Name = "areaLegsButton";
            this.areaLegsButton.Size = new System.Drawing.Size(98, 55);
            this.areaLegsButton.TabIndex = 8;
            this.areaLegsButton.Text = "Unlock Next Area\r\n (40 Chest Points)";
            this.areaLegsButton.UseVisualStyleBackColor = true;
            this.areaLegsButton.Click += new System.EventHandler(this.areaLegsButton_Click);
            // 
            // chestWeightUpButton
            // 
            this.chestWeightUpButton.Location = new System.Drawing.Point(10, 357);
            this.chestWeightUpButton.Name = "chestWeightUpButton";
            this.chestWeightUpButton.Size = new System.Drawing.Size(109, 34);
            this.chestWeightUpButton.TabIndex = 6;
            this.chestWeightUpButton.Text = "Up Weight \r\n(10 Chest Points)";
            this.chestWeightUpButton.UseVisualStyleBackColor = true;
            this.chestWeightUpButton.Click += new System.EventHandler(this.chestWeightUpButton_Click);
            // 
            // armAreaButton
            // 
            this.armAreaButton.Location = new System.Drawing.Point(3, 31);
            this.armAreaButton.Name = "armAreaButton";
            this.armAreaButton.Size = new System.Drawing.Size(106, 35);
            this.armAreaButton.TabIndex = 16;
            this.armAreaButton.Text = "Back to Arms";
            this.armAreaButton.UseVisualStyleBackColor = true;
            this.armAreaButton.Click += new System.EventHandler(this.armAreaButton_Click);
            // 
            // chestGameTimer
            // 
            this.chestGameTimer.Enabled = true;
            this.chestGameTimer.Interval = 20;
            this.chestGameTimer.Tick += new System.EventHandler(this.chestGameTimer_Tick);
            // 
            // ChestArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MuscleMayhemPenguinBrawl.Properties.Resources.ChestImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.armAreaButton);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.backPointsLabel);
            this.Controls.Add(this.legPointsLabel);
            this.Controls.Add(this.chestPointsLabel);
            this.Controls.Add(this.armPointsLabel);
            this.Controls.Add(this.chestLiftButton);
            this.Controls.Add(this.skillButton);
            this.Controls.Add(this.areaLegsButton);
            this.Controls.Add(this.chestWeightUpButton);
            this.DoubleBuffered = true;
            this.Name = "ChestArea";
            this.Size = new System.Drawing.Size(703, 442);
            this.Load += new System.EventHandler(this.ChestArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.Label backPointsLabel;
        private System.Windows.Forms.Label legPointsLabel;
        private System.Windows.Forms.Label chestPointsLabel;
        private System.Windows.Forms.Label armPointsLabel;
        private System.Windows.Forms.Button chestLiftButton;
        private System.Windows.Forms.Button skillButton;
        private System.Windows.Forms.Button areaLegsButton;
        private System.Windows.Forms.Button chestWeightUpButton;
        private System.Windows.Forms.Button armAreaButton;
        private System.Windows.Forms.Timer chestGameTimer;
    }
}
