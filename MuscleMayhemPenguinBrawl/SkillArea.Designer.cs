namespace MuscleMayhemPenguinBrawl
{
    partial class SkillArea
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
            this.strengthUpButton = new System.Windows.Forms.Button();
            this.healthUpButton = new System.Windows.Forms.Button();
            this.speedUpButton = new System.Windows.Forms.Button();
            this.laserUpButton = new System.Windows.Forms.Button();
            this.battleAreaButton = new System.Windows.Forms.Button();
            this.strenghtLevelLabel = new System.Windows.Forms.Label();
            this.healthLevelLabel = new System.Windows.Forms.Label();
            this.speedLevelLabel = new System.Windows.Forms.Label();
            this.laserLevelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strengthUpButton
            // 
            this.strengthUpButton.Location = new System.Drawing.Point(89, 125);
            this.strengthUpButton.Name = "strengthUpButton";
            this.strengthUpButton.Size = new System.Drawing.Size(111, 59);
            this.strengthUpButton.TabIndex = 0;
            this.strengthUpButton.Text = "Strength";
            this.strengthUpButton.UseVisualStyleBackColor = true;
            this.strengthUpButton.Click += new System.EventHandler(this.strengthUpButton_Click);
            // 
            // healthUpButton
            // 
            this.healthUpButton.Location = new System.Drawing.Point(330, 125);
            this.healthUpButton.Name = "healthUpButton";
            this.healthUpButton.Size = new System.Drawing.Size(130, 59);
            this.healthUpButton.TabIndex = 1;
            this.healthUpButton.UseVisualStyleBackColor = true;
            this.healthUpButton.Click += new System.EventHandler(this.healthUpButton_Click);
            // 
            // speedUpButton
            // 
            this.speedUpButton.Location = new System.Drawing.Point(583, 125);
            this.speedUpButton.Name = "speedUpButton";
            this.speedUpButton.Size = new System.Drawing.Size(117, 59);
            this.speedUpButton.TabIndex = 2;
            this.speedUpButton.UseVisualStyleBackColor = true;
            this.speedUpButton.Click += new System.EventHandler(this.speedUpButton_Click);
            // 
            // laserUpButton
            // 
            this.laserUpButton.Location = new System.Drawing.Point(801, 125);
            this.laserUpButton.Name = "laserUpButton";
            this.laserUpButton.Size = new System.Drawing.Size(109, 59);
            this.laserUpButton.TabIndex = 3;
            this.laserUpButton.UseVisualStyleBackColor = true;
            this.laserUpButton.Click += new System.EventHandler(this.laserUpButton_Click);
            // 
            // battleAreaButton
            // 
            this.battleAreaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleAreaButton.Location = new System.Drawing.Point(360, 412);
            this.battleAreaButton.Name = "battleAreaButton";
            this.battleAreaButton.Size = new System.Drawing.Size(330, 119);
            this.battleAreaButton.TabIndex = 4;
            this.battleAreaButton.Text = "Battle";
            this.battleAreaButton.UseVisualStyleBackColor = true;
            this.battleAreaButton.Click += new System.EventHandler(this.battleAreaButton_Click);
            // 
            // strenghtLevelLabel
            // 
            this.strenghtLevelLabel.AutoSize = true;
            this.strenghtLevelLabel.Location = new System.Drawing.Point(114, 50);
            this.strenghtLevelLabel.Name = "strenghtLevelLabel";
            this.strenghtLevelLabel.Size = new System.Drawing.Size(50, 13);
            this.strenghtLevelLabel.TabIndex = 5;
            this.strenghtLevelLabel.Text = "Strength:";
            // 
            // healthLevelLabel
            // 
            this.healthLevelLabel.AutoSize = true;
            this.healthLevelLabel.Location = new System.Drawing.Point(327, 50);
            this.healthLevelLabel.Name = "healthLevelLabel";
            this.healthLevelLabel.Size = new System.Drawing.Size(0, 13);
            this.healthLevelLabel.TabIndex = 6;
            // 
            // speedLevelLabel
            // 
            this.speedLevelLabel.AutoSize = true;
            this.speedLevelLabel.Location = new System.Drawing.Point(580, 50);
            this.speedLevelLabel.Name = "speedLevelLabel";
            this.speedLevelLabel.Size = new System.Drawing.Size(0, 13);
            this.speedLevelLabel.TabIndex = 7;
            // 
            // laserLevelLabel
            // 
            this.laserLevelLabel.AutoSize = true;
            this.laserLevelLabel.Location = new System.Drawing.Point(798, 60);
            this.laserLevelLabel.Name = "laserLevelLabel";
            this.laserLevelLabel.Size = new System.Drawing.Size(0, 13);
            this.laserLevelLabel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Skills/Abilities";
            // 
            // SkillArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laserLevelLabel);
            this.Controls.Add(this.speedLevelLabel);
            this.Controls.Add(this.healthLevelLabel);
            this.Controls.Add(this.strenghtLevelLabel);
            this.Controls.Add(this.battleAreaButton);
            this.Controls.Add(this.laserUpButton);
            this.Controls.Add(this.speedUpButton);
            this.Controls.Add(this.healthUpButton);
            this.Controls.Add(this.strengthUpButton);
            this.DoubleBuffered = true;
            this.Name = "SkillArea";
            this.Size = new System.Drawing.Size(1024, 768);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button strengthUpButton;
        private System.Windows.Forms.Button healthUpButton;
        private System.Windows.Forms.Button speedUpButton;
        private System.Windows.Forms.Button laserUpButton;
        private System.Windows.Forms.Button battleAreaButton;
        private System.Windows.Forms.Label strenghtLevelLabel;
        private System.Windows.Forms.Label healthLevelLabel;
        private System.Windows.Forms.Label speedLevelLabel;
        private System.Windows.Forms.Label laserLevelLabel;
        private System.Windows.Forms.Label label1;
    }
}
