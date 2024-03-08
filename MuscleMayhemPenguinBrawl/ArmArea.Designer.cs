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
            this.armEquipUpButton = new System.Windows.Forms.Button();
            this.areaChestButton = new System.Windows.Forms.Button();
            this.skillButton = new System.Windows.Forms.Button();
            this.armGameTimer = new System.Windows.Forms.Timer(this.components);
            this.armLiftButton = new System.Windows.Forms.Button();
            this.armPointsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // armWeightUpButton
            // 
            this.armWeightUpButton.Location = new System.Drawing.Point(17, 354);
            this.armWeightUpButton.Name = "armWeightUpButton";
            this.armWeightUpButton.Size = new System.Drawing.Size(75, 23);
            this.armWeightUpButton.TabIndex = 0;
            this.armWeightUpButton.Text = "Up Weight";
            this.armWeightUpButton.UseVisualStyleBackColor = true;
            this.armWeightUpButton.Click += new System.EventHandler(this.armWeightUpButton_Click);
            // 
            // armEquipUpButton
            // 
            this.armEquipUpButton.Location = new System.Drawing.Point(285, 3);
            this.armEquipUpButton.Name = "armEquipUpButton";
            this.armEquipUpButton.Size = new System.Drawing.Size(146, 23);
            this.armEquipUpButton.TabIndex = 1;
            this.armEquipUpButton.Text = "Upgrade Equipment";
            this.armEquipUpButton.UseVisualStyleBackColor = true;
            this.armEquipUpButton.Click += new System.EventHandler(this.armEquipUpButton_Click);
            // 
            // areaChestButton
            // 
            this.areaChestButton.Location = new System.Drawing.Point(602, 176);
            this.areaChestButton.Name = "areaChestButton";
            this.areaChestButton.Size = new System.Drawing.Size(98, 55);
            this.areaChestButton.TabIndex = 2;
            this.areaChestButton.Text = "Unlock Next Area";
            this.areaChestButton.UseVisualStyleBackColor = true;
            this.areaChestButton.Click += new System.EventHandler(this.areaChestButton_Click);
            // 
            // skillButton
            // 
            this.skillButton.Location = new System.Drawing.Point(602, 384);
            this.skillButton.Name = "skillButton";
            this.skillButton.Size = new System.Drawing.Size(98, 55);
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
            this.armLiftButton.Location = new System.Drawing.Point(285, 384);
            this.armLiftButton.Name = "armLiftButton";
            this.armLiftButton.Size = new System.Drawing.Size(110, 55);
            this.armLiftButton.TabIndex = 4;
            this.armLiftButton.Text = "Lift";
            this.armLiftButton.UseVisualStyleBackColor = true;
            this.armLiftButton.Click += new System.EventHandler(this.armLiftButton_Click);
            // 
            // armPointsLabel
            // 
            this.armPointsLabel.AutoSize = true;
            this.armPointsLabel.Location = new System.Drawing.Point(599, 38);
            this.armPointsLabel.Name = "armPointsLabel";
            this.armPointsLabel.Size = new System.Drawing.Size(13, 13);
            this.armPointsLabel.TabIndex = 5;
            this.armPointsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // ArmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.armPointsLabel);
            this.Controls.Add(this.armLiftButton);
            this.Controls.Add(this.skillButton);
            this.Controls.Add(this.areaChestButton);
            this.Controls.Add(this.armEquipUpButton);
            this.Controls.Add(this.armWeightUpButton);
            this.Name = "ArmArea";
            this.Size = new System.Drawing.Size(703, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button armWeightUpButton;
        private System.Windows.Forms.Button armEquipUpButton;
        private System.Windows.Forms.Button areaChestButton;
        private System.Windows.Forms.Button skillButton;
        private System.Windows.Forms.Timer armGameTimer;
        private System.Windows.Forms.Button armLiftButton;
        private System.Windows.Forms.Label armPointsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
