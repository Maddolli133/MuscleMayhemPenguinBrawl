namespace MuscleMayhemPenguinBrawl
{
    partial class LegsArea
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
            this.chestAreaButton = new System.Windows.Forms.Button();
            this.coinLabel = new System.Windows.Forms.Label();
            this.backPointsLabel = new System.Windows.Forms.Label();
            this.legPointsLabel = new System.Windows.Forms.Label();
            this.chestPointsLabel = new System.Windows.Forms.Label();
            this.armPointsLabel = new System.Windows.Forms.Label();
            this.legsLiftButton = new System.Windows.Forms.Button();
            this.skillButton = new System.Windows.Forms.Button();
            this.areaBackButton = new System.Windows.Forms.Button();
            this.legsWeightUpButton = new System.Windows.Forms.Button();
            this.legGameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chestAreaButton
            // 
            this.chestAreaButton.Location = new System.Drawing.Point(6, 31);
            this.chestAreaButton.Name = "chestAreaButton";
            this.chestAreaButton.Size = new System.Drawing.Size(106, 35);
            this.chestAreaButton.TabIndex = 27;
            this.chestAreaButton.Text = "Back to Chest";
            this.chestAreaButton.UseVisualStyleBackColor = true;
            this.chestAreaButton.Click += new System.EventHandler(this.chestAreaButton_Click);
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Location = new System.Drawing.Point(595, 41);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(13, 13);
            this.coinLabel.TabIndex = 22;
            this.coinLabel.Text = "0";
            // 
            // backPointsLabel
            // 
            this.backPointsLabel.AutoSize = true;
            this.backPointsLabel.Location = new System.Drawing.Point(595, 105);
            this.backPointsLabel.Name = "backPointsLabel";
            this.backPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.backPointsLabel.TabIndex = 23;
            this.backPointsLabel.Text = "0";
            // 
            // legPointsLabel
            // 
            this.legPointsLabel.AutoSize = true;
            this.legPointsLabel.Location = new System.Drawing.Point(595, 92);
            this.legPointsLabel.Name = "legPointsLabel";
            this.legPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.legPointsLabel.TabIndex = 24;
            this.legPointsLabel.Text = "0";
            // 
            // chestPointsLabel
            // 
            this.chestPointsLabel.AutoSize = true;
            this.chestPointsLabel.Location = new System.Drawing.Point(595, 79);
            this.chestPointsLabel.Name = "chestPointsLabel";
            this.chestPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.chestPointsLabel.TabIndex = 25;
            this.chestPointsLabel.Text = "0";
            // 
            // armPointsLabel
            // 
            this.armPointsLabel.AutoSize = true;
            this.armPointsLabel.Location = new System.Drawing.Point(595, 66);
            this.armPointsLabel.Name = "armPointsLabel";
            this.armPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.armPointsLabel.TabIndex = 26;
            this.armPointsLabel.Text = "0";
            // 
            // legsLiftButton
            // 
            this.legsLiftButton.Location = new System.Drawing.Point(453, 592);
            this.legsLiftButton.Name = "legsLiftButton";
            this.legsLiftButton.Size = new System.Drawing.Size(138, 76);
            this.legsLiftButton.TabIndex = 21;
            this.legsLiftButton.Text = "Lift";
            this.legsLiftButton.UseVisualStyleBackColor = true;
            this.legsLiftButton.Click += new System.EventHandler(this.legsLiftButton_Click);
            // 
            // skillButton
            // 
            this.skillButton.Location = new System.Drawing.Point(900, 592);
            this.skillButton.Name = "skillButton";
            this.skillButton.Size = new System.Drawing.Size(121, 86);
            this.skillButton.TabIndex = 20;
            this.skillButton.Text = "Skill Upgrade";
            this.skillButton.UseVisualStyleBackColor = true;
            this.skillButton.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // areaBackButton
            // 
            this.areaBackButton.Location = new System.Drawing.Point(892, 247);
            this.areaBackButton.Name = "areaBackButton";
            this.areaBackButton.Size = new System.Drawing.Size(118, 68);
            this.areaBackButton.TabIndex = 19;
            this.areaBackButton.Text = "Unlock Next Area\r\n (60)";
            this.areaBackButton.UseVisualStyleBackColor = true;
            this.areaBackButton.Click += new System.EventHandler(this.areaBackButton_Click);
            // 
            // legsWeightUpButton
            // 
            this.legsWeightUpButton.Location = new System.Drawing.Point(6, 538);
            this.legsWeightUpButton.Name = "legsWeightUpButton";
            this.legsWeightUpButton.Size = new System.Drawing.Size(150, 60);
            this.legsWeightUpButton.TabIndex = 17;
            this.legsWeightUpButton.Text = "Up Weight \r\n(10 Leg Points)";
            this.legsWeightUpButton.UseVisualStyleBackColor = true;
            this.legsWeightUpButton.Click += new System.EventHandler(this.legsWeightUpButton_Click);
            // 
            // legGameTimer
            // 
            this.legGameTimer.Enabled = true;
            this.legGameTimer.Interval = 20;
            this.legGameTimer.Tick += new System.EventHandler(this.legGameTimer_Tick);
            // 
            // LegsArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::MuscleMayhemPenguinBrawl.Properties.Resources.LegImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.chestAreaButton);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.backPointsLabel);
            this.Controls.Add(this.legPointsLabel);
            this.Controls.Add(this.chestPointsLabel);
            this.Controls.Add(this.armPointsLabel);
            this.Controls.Add(this.legsLiftButton);
            this.Controls.Add(this.skillButton);
            this.Controls.Add(this.areaBackButton);
            this.Controls.Add(this.legsWeightUpButton);
            this.DoubleBuffered = true;
            this.Name = "LegsArea";
            this.Size = new System.Drawing.Size(1024, 768);
            this.Load += new System.EventHandler(this.LegsArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chestAreaButton;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.Label backPointsLabel;
        private System.Windows.Forms.Label legPointsLabel;
        private System.Windows.Forms.Label chestPointsLabel;
        private System.Windows.Forms.Label armPointsLabel;
        private System.Windows.Forms.Button legsLiftButton;
        private System.Windows.Forms.Button skillButton;
        private System.Windows.Forms.Button areaBackButton;
        private System.Windows.Forms.Button legsWeightUpButton;
        private System.Windows.Forms.Timer legGameTimer;
    }
}
