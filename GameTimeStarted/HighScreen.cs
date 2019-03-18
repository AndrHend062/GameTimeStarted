using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GameTimeStarted
{
    public partial class HighScreen : UserControl
    {
        public HighScreen()
        {
            InitializeComponent();
           
        }
        

        private void HighScreen_Load(object sender, EventArgs e)
        {
            XmlReader reader = XmlReader.Create("Resources/HighScore.xml");
            highScoreLabel.Text = "o no ";

        }
    }
}
