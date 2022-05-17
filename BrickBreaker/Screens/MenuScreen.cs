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
    public partial class MenuScreen : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.Star_Wars__The_Imperial_March__Darth_Vader_s_Theme_);

        public MenuScreen()
        {
            InitializeComponent();
            TrentSound();
        }

        public void TrentSound()
        {
            //Background sound for the menuScreen
            
            player.Play();
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

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

            form.Controls.Add(gs);
            form.Controls.Remove(this);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            // Trent: Goes to the OptionScreen
            OptionsScreen os = new OptionsScreen();
            Form form = this.FindForm();

            form.Controls.Add(os);
            form.Controls.Remove(this);

            os.Location = new Point((form.Width - os.Width) / 2, (form.Height - os.Height) / 2);
        }
    }
}
