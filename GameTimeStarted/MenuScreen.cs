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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {   
            Form f = FindForm();
            GameScreen gS = new GameScreen();
            f.Controls.Add(gS);
           // gS.Location = (MenuScreen.width, 0);
            f.Controls.Remove(this);
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
