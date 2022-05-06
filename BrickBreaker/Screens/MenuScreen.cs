using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BrickBreaker
{
  
    public partial class menuScreen : UserControl
    {
        public void TrentSound()
        {
            //Background sound for the menuScreen
            SoundPlayer player = new SoundPlayer(Properties.Resources.Star_Wars__The_Imperial_March__Darth_Vader_s_Theme_);

            player.Play();

        }
        public menuScreen()
        {
           InitializeComponent();

            TrentSound();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        private void menuTitle_Click(object sender, EventArgs e)
        {

        }


        private void optionsButton_Click(object sender, EventArgs e)
        {
            // Trent: Goes to the HowToPlayscreen
            HowToPlayScreen gs = new HowToPlayScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

        }
    }
}
