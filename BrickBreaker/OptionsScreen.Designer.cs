namespace BrickBreaker
{
    partial class OptionsScreen
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
            this.howToPlayButton = new System.Windows.Forms.Button();
            this.powerupButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // howToPlayButton
            // 
            this.howToPlayButton.AutoSize = true;
            this.howToPlayButton.BackColor = System.Drawing.Color.Transparent;
            this.howToPlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.howToPlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.howToPlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.howToPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howToPlayButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToPlayButton.ForeColor = System.Drawing.Color.Gold;
            this.howToPlayButton.Location = new System.Drawing.Point(328, 139);
            this.howToPlayButton.Name = "howToPlayButton";
            this.howToPlayButton.Size = new System.Drawing.Size(227, 77);
            this.howToPlayButton.TabIndex = 1;
            this.howToPlayButton.Text = "How To Play";
            this.howToPlayButton.UseVisualStyleBackColor = false;
            this.howToPlayButton.Click += new System.EventHandler(this.howToPlayButton_Click);
            // 
            // powerupButton
            // 
            this.powerupButton.AutoSize = true;
            this.powerupButton.BackColor = System.Drawing.Color.Transparent;
            this.powerupButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.powerupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.powerupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.powerupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerupButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerupButton.ForeColor = System.Drawing.Color.Gold;
            this.powerupButton.Location = new System.Drawing.Point(328, 253);
            this.powerupButton.Name = "powerupButton";
            this.powerupButton.Size = new System.Drawing.Size(227, 77);
            this.powerupButton.TabIndex = 2;
            this.powerupButton.Text = "Powerups";
            this.powerupButton.UseVisualStyleBackColor = false;
            this.powerupButton.Click += new System.EventHandler(this.powerupButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Gold;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 50);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OptionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.SpaceBackground;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.powerupButton);
            this.Controls.Add(this.howToPlayButton);
            this.Name = "OptionsScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button howToPlayButton;
        private System.Windows.Forms.Button powerupButton;
        private System.Windows.Forms.Button backButton;
    }
}
