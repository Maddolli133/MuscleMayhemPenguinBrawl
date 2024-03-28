namespace MuscleMayhemPenguinBrawl
{
    partial class ArmArea
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
            this.armWeightUpButton = new System.Windows.Forms.Button();
            this.areaChestButton = new System.Windows.Forms.Button();
            this.skillButton = new System.Windows.Forms.Button();
            this.armGameTimer = new System.Windows.Forms.Timer(this.components);
            this.armLiftButton = new System.Windows.Forms.Button();
            this.armPointsLabel = new System.Windows.Forms.Label();
            this.chestPointsLabel = new System.Windows.Forms.Label();
            this.legPointsLabel = new System.Windows.Forms.Label();
            this.backPointsLabel = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // armWeightUpButton
            // 
            this.armWeightUpButton.Location = new System.Drawing.Point(17, 519);
            this.armWeightUpButton.Name = "armWeightUpButton";
            this.armWeightUpButton.Size = new System.Drawing.Size(132, 73);
            this.armWeightUpButton.TabIndex = 0;
            this.armWeightUpButton.Text = "Up Weight \r\n(10 Arm Points)";
            this.armWeightUpButton.UseVisualStyleBackColor = true;
            this.armWeightUpButton.Click += new System.EventHandler(this.armWeightUpButton_Click);
            // 
            // areaChestButton
            // 
            this.areaChestButton.Location = new System.Drawing.Point(910, 424);
            this.areaChestButton.Name = "areaChestButton";
            this.areaChestButton.Size = new System.Drawing.Size(111, 106);
            this.areaChestButton.TabIndex = 2;
            this.areaChestButton.Text = "Unlock Next Area \r\n(20 Arm Points)";
            this.areaChestButton.UseVisualStyleBackColor = true;
            this.areaChestButton.Click += new System.EventHandler(this.areaChestButton_Click);
            // 
            // skillButton
            // 
            this.skillButton.Location = new System.Drawing.Point(890, 664);
            this.skillButton.Name = "skillButton";
            this.skillButton.Size = new System.Drawing.Size(122, 80);
            this.skillButton.TabIndex = 3;
            this.skillButton.Text = "Skill Upgrade";
            this.skillButton.UseVisualStyleBackColor = true;
            this.skillButton.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // armGameTimer
            // 
            this.armGameTimer.Enabled = true;
            this.armGameTimer.Interval = 20;
            this.armGameTimer.Tick += new System.EventHandler(this.armGameTimer_Tick);
            // 
            // armLiftButton
            // 
            this.armLiftButton.Location = new System.Drawing.Point(443, 664);
            this.armLiftButton.Name = "armLiftButton";
            this.armLiftButton.Size = new System.Drawing.Size(188, 80);
            this.armLiftButton.TabIndex = 4;
            this.armLiftButton.Text = "Lift";
            this.armLiftButton.UseVisualStyleBackColor = true;
            this.armLiftButton.Click += new System.EventHandler(this.armLiftButton_Click);
            // 
            // armPointsLabel
            // 
            this.armPointsLabel.AutoSize = true;
            this.armPointsLabel.BackColor = System.Drawing.Color.White;
            this.armPointsLabel.Location = new System.Drawing.Point(878, 54);
            this.armPointsLabel.Name = "armPointsLabel";
            this.armPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.armPointsLabel.TabIndex = 5;
            this.armPointsLabel.Text = "0";
            // 
            // chestPointsLabel
            // 
            this.chestPointsLabel.AutoSize = true;
            this.chestPointsLabel.BackColor = System.Drawing.Color.White;
            this.chestPointsLabel.Location = new System.Drawing.Point(878, 67);
            this.chestPointsLabel.Name = "chestPointsLabel";
            this.chestPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.chestPointsLabel.TabIndex = 5;
            this.chestPointsLabel.Text = "0";
            // 
            // legPointsLabel
            // 
            this.legPointsLabel.AutoSize = true;
            this.legPointsLabel.BackColor = System.Drawing.Color.White;
            this.legPointsLabel.Location = new System.Drawing.Point(878, 80);
            this.legPointsLabel.Name = "legPointsLabel";
            this.legPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.legPointsLabel.TabIndex = 5;
            this.legPointsLabel.Text = "0";
            // 
            // backPointsLabel
            // 
            this.backPointsLabel.AutoSize = true;
            this.backPointsLabel.BackColor = System.Drawing.Color.White;
            this.backPointsLabel.Location = new System.Drawing.Point(878, 93);
            this.backPointsLabel.Name = "backPointsLabel";
            this.backPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.backPointsLabel.TabIndex = 5;
            this.backPointsLabel.Text = "0";
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.BackColor = System.Drawing.Color.White;
            this.coinLabel.Location = new System.Drawing.Point(878, 29);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(13, 13);
            this.coinLabel.TabIndex = 5;
            this.coinLabel.Text = "0";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(460, 20);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 47);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Quit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ArmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::MuscleMayhemPenguinBrawl.Properties.Resources.ArmImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.backPointsLabel);
            this.Controls.Add(this.legPointsLabel);
            this.Controls.Add(this.chestPointsLabel);
            this.Controls.Add(this.armPointsLabel);
            this.Controls.Add(this.armLiftButton);
            this.Controls.Add(this.skillButton);
            this.Controls.Add(this.areaChestButton);
            this.Controls.Add(this.armWeightUpButton);
            this.DoubleBuffered = true;
            this.Name = "ArmArea";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.ArmArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button armWeightUpButton;
        private System.Windows.Forms.Button areaChestButton;
        private System.Windows.Forms.Button skillButton;
        private System.Windows.Forms.Timer armGameTimer;
        private System.Windows.Forms.Button armLiftButton;
        private System.Windows.Forms.Label armPointsLabel;
        private System.Windows.Forms.Label chestPointsLabel;
        private System.Windows.Forms.Label legPointsLabel;
        private System.Windows.Forms.Label backPointsLabel;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.Button exitButton;
    }
}
