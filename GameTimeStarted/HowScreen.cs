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
    public partial class HowScreen : UserControl
    {
        SolidBrush drawBrush = new SolidBrush(Color.AntiqueWhite);
        List<Rectangle> cloud = new List<Rectangle>();
        Rectangle rect;
        
        public HowScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart()
        {
            cloud.Add(rect = new Rectangle(1,50,100,100));
            cloud.Add(rect = new Rectangle(5, 70, 110, 90));
            cloud.Add(rect = new Rectangle(15, 100, 100, 120));
            cloud.Add(rect = new Rectangle(30, 100, 200, 100));
            cloud.Add(rect = new Rectangle(50, 40, 150, 40));
            cloud.Add(rect = new Rectangle(60, 60, 120, 80));
            cloud.Add(rect = new Rectangle(140, 60, 120, 80));
        }

        private void HowScreen_Paint(object sender, PaintEventArgs e)
        { 
            foreach (Rectangle x in cloud)
            {
                e.Graphics.FillEllipse(drawBrush, x);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form f = FindForm();
            MenuScreen gS = new MenuScreen();
            f.Controls.Add(gS);
            gS.Location = new Point(Location.X, 0);
            f.Controls.Remove(this);
        }
    }
}
