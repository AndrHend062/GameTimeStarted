using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTimeStarted
{
    public partial class GameForm : Form
    {
        public static int score = 0;
        public GameForm()
        {
            InitializeComponent();
           

        }

        
        public void ScoreReset()
        { score = 0;}

        private void GameForm_Load(object sender, EventArgs e)
        {
           // this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
           // this.WindowState = FormWindowState.Maximized;
            MenuScreen f = new MenuScreen();
            this.Controls.Add(f);
            f.Location = new Point((this.Width-f.Width) / 2  , 0);
            Cursor.Hide();
        }
    }
}
