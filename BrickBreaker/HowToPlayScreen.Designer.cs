
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
            this.liveslabel = new System.Windows.Forms.Label();
            this.livesInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(129, 50);
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
            this.menuTitle.Location = new System.Drawing.Point(137, 0);
            this.menuTitle.Margin = new System.Windows.Forms.Padding(0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(505, 68);
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
            this.paddle.Location = new System.Drawing.Point(-7, 100);
            this.paddle.Margin = new System.Windows.Forms.Padding(0);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(323, 99);
            this.paddle.TabIndex = 4;
            this.paddle.Text = "Paddle Controls:";
            this.paddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paddleControls
            // 
            this.paddleControls.BackColor = System.Drawing.Color.Transparent;
            this.paddleControls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paddleControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paddleControls.ForeColor = System.Drawing.Color.Gold;
            this.paddleControls.Location = new System.Drawing.Point(290, 112);
            this.paddleControls.Margin = new System.Windows.Forms.Padding(0);
            this.paddleControls.Name = "paddleControls";
            this.paddleControls.Size = new System.Drawing.Size(530, 87);
            this.paddleControls.TabIndex = 5;
            this.paddleControls.Text = "Use <-- --> keys to \r\nmove the player left and right\r\n\r\n";
            this.paddleControls.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // liveslabel
            // 
            this.liveslabel.BackColor = System.Drawing.Color.Transparent;
            this.liveslabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.liveslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveslabel.ForeColor = System.Drawing.Color.Gold;
            this.liveslabel.Location = new System.Drawing.Point(0, 275);
            this.liveslabel.Margin = new System.Windows.Forms.Padding(0);
            this.liveslabel.Name = "liveslabel";
            this.liveslabel.Size = new System.Drawing.Size(150, 65);
            this.liveslabel.TabIndex = 8;
            this.liveslabel.Text = "Lives:";
            this.liveslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.liveslabel.Click += new System.EventHandler(this.liveslabel_Click);
            // 
            // livesInstructions
            // 
            this.livesInstructions.BackColor = System.Drawing.Color.Transparent;
            this.livesInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.livesInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesInstructions.ForeColor = System.Drawing.Color.Gold;
            this.livesInstructions.Location = new System.Drawing.Point(290, 241);
            this.livesInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.livesInstructions.Name = "livesInstructions";
            this.livesInstructions.Size = new System.Drawing.Size(553, 152);
            this.livesInstructions.TabIndex = 9;
            this.livesInstructions.Text = "Start with three lives\r\n\r\nGet powerups for more lives\r\n\r\n";
            this.livesInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "Objective:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(301, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(508, 107);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destroy all bricks to progress \r\nthrough a level";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(-30, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(913, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "____________________________________________________________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(-30, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(913, 44);
            this.label4.TabIndex = 13;
            this.label4.Text = "____________________________________________________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(-30, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(913, 44);
            this.label5.TabIndex = 14;
            this.label5.Text = "____________________________________________________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToPlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.SpaceBackground;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livesInstructions);
            this.Controls.Add(this.liveslabel);
            this.Controls.Add(this.paddleControls);
            this.Controls.Add(this.paddle);
            this.Controls.Add(this.menuTitle);
            this.Controls.Add(this.backButton);
            this.Name = "HowToPlayScreen";
            this.Size = new System.Drawing.Size(854, 542);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label menuTitle;
        private System.Windows.Forms.Label paddle;
        private System.Windows.Forms.Label paddleControls;
        private System.Windows.Forms.Label liveslabel;
        private System.Windows.Forms.Label livesInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
