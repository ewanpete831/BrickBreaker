namespace BrickBreaker
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuTitle = new System.Windows.Forms.Label();
            this.optionsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Gold;
            this.playButton.Location = new System.Drawing.Point(336, 217);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(194, 77);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Gold;
            this.exitButton.Location = new System.Drawing.Point(336, 383);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 77);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuTitle
            // 
            this.menuTitle.BackColor = System.Drawing.Color.Transparent;
            this.menuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.ForeColor = System.Drawing.Color.Gold;
            this.menuTitle.Location = new System.Drawing.Point(277, 61);
            this.menuTitle.Margin = new System.Windows.Forms.Padding(0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(314, 127);
            this.menuTitle.TabIndex = 2;
            this.menuTitle.Text = " STAR\r\nWARS\r\n";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.optionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.optionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsButton.ForeColor = System.Drawing.Color.Gold;
            this.optionsButton.Location = new System.Drawing.Point(336, 299);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(194, 79);
            this.optionsButton.TabIndex = 3;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.SpaceBackground;
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Button optionsButton;
    }
}
