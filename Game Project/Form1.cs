using Game_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project
{
    public partial class GunPlay : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public GunPlay()
        {
            InitializeComponent();
 
        }
        Random r = new Random();
        int score = 0;
        int count = 60;
        //Gunshot
        void fn_shot()
        {
            score++;
            label1.Text = "Score: " + score;
            FireGun();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Countdown Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            count -= 1;
            x = r.Next(0, 700);
            y = r.Next(180, 300);
            pictureBox1.Location = new Point(x, y);
            label2.Text = "Timer: " + count;
            if (count == 0)
            {
                timer1.Stop();
                //MessageBox.Show("Game Over!!!");
                CustomMsgBox.Show("Game Over!!!", "Msg", "Retry", "Cancel");
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        //On-screen Target
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fn_shot();
            
        }
        //Sound Effect
        private void FireGun()
        {
            SoundPlayer simplesound = new SoundPlayer(Resources.GunShot);
            simplesound.Play();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
