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
        Form f;
        GameForm gForm;

        public EndScreen()
        {
            InitializeComponent();
            
            scoreLabel.Text = "YOUR SCORE \n" + GameForm.score;
            GameForm.score = 0;
           
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            f = FindForm();
            gForm = f as GameForm;
            f.Controls.Add(new MenuScreen());
            f.Controls.Remove(this);
           

        }
    }
}
