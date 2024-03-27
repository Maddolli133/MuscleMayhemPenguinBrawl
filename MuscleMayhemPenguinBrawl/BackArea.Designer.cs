namespace MuscleMayhemPenguinBrawl
{
    partial class BackArea
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
            this.legsAreaButton = new System.Windows.Forms.Button();
            this.coinLabel = new System.Windows.Forms.Label();
            this.backPointsLabel = new System.Windows.Forms.Label();
            this.legPointsLabel = new System.Windows.Forms.Label();
            this.chestPointsLabel = new System.Windows.Forms.Label();
            this.armPointsLabel = new System.Windows.Forms.Label();
            this.backLiftButton = new System.Windows.Forms.Button();
            this.skillButton = new System.Windows.Forms.Button();
            this.backWeightUpButton = new System.Windows.Forms.Button();
            this.legsGameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // legsAreaButton
            // 
            this.legsAreaButton.Location = new System.Drawing.Point(6, 31);
            this.legsAreaButton.Name = "legsAreaButton";
            this.legsAreaButton.Size = new System.Drawing.Size(106, 35);
            this.legsAreaButton.TabIndex = 38;
            this.legsAreaButton.Text = "Back to Legs";
            this.legsAreaButton.UseVisualStyleBackColor = true;
            this.legsAreaButton.Click += new System.EventHandler(this.legsAreaButton_Click);
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Location = new System.Drawing.Point(595, 41);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(13, 13);
            this.coinLabel.TabIndex = 33;
            this.coinLabel.Text = "0";
            // 
            // backPointsLabel
            // 
            this.backPointsLabel.AutoSize = true;
            this.backPointsLabel.Location = new System.Drawing.Point(595, 105);
            this.backPointsLabel.Name = "backPointsLabel";
            this.backPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.backPointsLabel.TabIndex = 34;
            this.backPointsLabel.Text = "0";
            // 
            // legPointsLabel
            // 
            this.legPointsLabel.AutoSize = true;
            this.legPointsLabel.Location = new System.Drawing.Point(595, 92);
            this.legPointsLabel.Name = "legPointsLabel";
            this.legPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.legPointsLabel.TabIndex = 35;
            this.legPointsLabel.Text = "0";
            // 
            // chestPointsLabel
            // 
            this.chestPointsLabel.AutoSize = true;
            this.chestPointsLabel.Location = new System.Drawing.Point(595, 79);
            this.chestPointsLabel.Name = "chestPointsLabel";
            this.chestPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.chestPointsLabel.TabIndex = 36;
            this.chestPointsLabel.Text = "0";
            // 
            // armPointsLabel
            // 
            this.armPointsLabel.AutoSize = true;
            this.armPointsLabel.Location = new System.Drawing.Point(595, 66);
            this.armPointsLabel.Name = "armPointsLabel";
            this.armPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.armPointsLabel.TabIndex = 37;
            this.armPointsLabel.Text = "0";
            // 
            // backLiftButton
            // 
            this.backLiftButton.Location = new System.Drawing.Point(281, 357);
            this.backLiftButton.Name = "backLiftButton";
            this.backLiftButton.Size = new System.Drawing.Size(110, 55);
            this.backLiftButton.TabIndex = 32;
            this.backLiftButton.Text = "Lift";
            this.backLiftButton.UseVisualStyleBackColor = true;
            this.backLiftButton.Click += new System.EventHandler(this.backLiftButton_Click);
            // 
            // skillButton
            // 
            this.skillButton.Location = new System.Drawing.Point(598, 357);
            this.skillButton.Name = "skillButton";
            this.skillButton.Size = new System.Drawing.Size(98, 55);
            this.skillButton.TabIndex = 31;
            this.skillButton.Text = "Skill Upgrade";
            this.skillButton.UseVisualStyleBackColor = true;
            this.skillButton.Click += new System.EventHandler(this.skillButton_Click);
            // 
            // backWeightUpButton
            // 
            this.backWeightUpButton.Location = new System.Drawing.Point(13, 357);
            this.backWeightUpButton.Name = "backWeightUpButton";
            this.backWeightUpButton.Size = new System.Drawing.Size(109, 34);
            this.backWeightUpButton.TabIndex = 28;
            this.backWeightUpButton.Text = "Up Weight \r\n(10 Back Points)";
            this.backWeightUpButton.UseVisualStyleBackColor = true;
            this.backWeightUpButton.Click += new System.EventHandler(this.backWeightUpButton_Click);
            // 
            // legsGameTimer
            // 
            this.legsGameTimer.Enabled = true;
            this.legsGameTimer.Interval = 20;
            this.legsGameTimer.Tick += new System.EventHandler(this.legsGameTimer_Tick);
            // 
            // BackArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::MuscleMayhemPenguinBrawl.Properties.Resources.BackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.legsAreaButton);
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.backPointsLabel);
            this.Controls.Add(this.legPointsLabel);
            this.Controls.Add(this.chestPointsLabel);
            this.Controls.Add(this.armPointsLabel);
            this.Controls.Add(this.backLiftButton);
            this.Controls.Add(this.skillButton);
            this.Controls.Add(this.backWeightUpButton);
            this.DoubleBuffered = true;
            this.Name = "BackArea";
            this.Size = new System.Drawing.Size(703, 442);
            this.Load += new System.EventHandler(this.BackArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button legsAreaButton;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.Label backPointsLabel;
        private System.Windows.Forms.Label legPointsLabel;
        private System.Windows.Forms.Label chestPointsLabel;
        private System.Windows.Forms.Label armPointsLabel;
        private System.Windows.Forms.Button backLiftButton;
        private System.Windows.Forms.Button skillButton;
        private System.Windows.Forms.Button backWeightUpButton;
        private System.Windows.Forms.Timer legsGameTimer;
    }
}
