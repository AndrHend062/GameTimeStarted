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
    public partial class HighScreen : UserControl
    {
       
        public HighScreen()
        {
            InitializeComponent();
         
        }
        

        private void HighScreen_Load(object sender, EventArgs e)
        {foreach (int hs in GameForm.scoreList)
            {
                highScoreLabel.Text += "\n"+hs + "\n";

            }
        }

        private void menuScreenButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "MenuScreen");
        }
    }
}
