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
        XmlReader reader;
        public HighScreen()
        {
            InitializeComponent();
          //  reader = XmlReader.Create("Resources/HighScore.xml");
        }
        

        private void HighScreen_Load(object sender, EventArgs e)
        {
           
            //highScoreLabel.Text = "o no ";
            //while (reader.Read())

            //{

            //    if (reader.NodeType == XmlNodeType.Text)

            //    {

            //        highScoreLabel.Text += reader.Value + "\n";

            //    }

            //}

            //reader.Close();

        }
    }
}
