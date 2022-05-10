
namespace BrickBreaker
{
    partial class HowToPlayScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.menuTitle = new System.Windows.Forms.Label();
            this.paddle = new System.Windows.Forms.Label();
            this.paddleControls = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(194, 77);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // menuTitle
            // 
            this.menuTitle.BackColor = System.Drawing.Color.Transparent;
            this.menuTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitle.ForeColor = System.Drawing.Color.Gold;
            this.menuTitle.Location = new System.Drawing.Point(206, 0);
            this.menuTitle.Margin = new System.Windows.Forms.Padding(0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(757, 154);
            this.menuTitle.TabIndex = 3;
            this.menuTitle.Text = "How To Play";
            this.menuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.Color.Transparent;
            this.paddle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paddle.ForeColor = System.Drawing.Color.Gold;
            this.paddle.Location = new System.Drawing.Point(10, 172);
            this.paddle.Margin = new System.Windows.Forms.Padding(0);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(526, 153);
            this.paddle.TabIndex = 4;
            this.paddle.Text = "Paddle Controls";
            this.paddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paddleControls
            // 
            this.paddleControls.BackColor = System.Drawing.Color.Transparent;
            this.paddleControls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paddleControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paddleControls.ForeColor = System.Drawing.Color.Gold;
            this.paddleControls.Location = new System.Drawing.Point(536, 172);
            this.paddleControls.Margin = new System.Windows.Forms.Padding(0);
            this.paddleControls.Name = "paddleControls";
            this.paddleControls.Size = new System.Drawing.Size(716, 157);
            this.paddleControls.TabIndex = 5;
            this.paddleControls.Text = "Use the <-- --> keys to \r\nmove the player left and right\r\n\r\n";
            this.paddleControls.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HowToPlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.SpaceBackground;
            this.Controls.Add(this.paddleControls);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.backButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HowToPlayScreen";
            this.Size = new System.Drawing.Size(1281, 834);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Label paddle;
        private System.Windows.Forms.Label paddleControls;
    }
}
