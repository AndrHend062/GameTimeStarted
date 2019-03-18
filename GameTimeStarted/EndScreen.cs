using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTimeStarted
{
    public partial class EndScreen : UserControl
    {
       

        public EndScreen()
        {
            InitializeComponent();
            
            scoreLabel.Text = "YOUR SCORE \n" + GameForm.score;
            GameForm.score = 0;
            scoreLabel.Location = new Point((Width - scoreLabel.Width) / 2, 300);
            GameOverlabel.Location = new Point((Width - GameOverlabel.Width) / 2, 50);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
          
            Form f = FindForm();
            MenuScreen gS = new MenuScreen();
            f.Controls.Add(gS);
            gS.Location = new Point(Location.X, 0);
            f.Controls.Remove(this);


        }
    }
}
