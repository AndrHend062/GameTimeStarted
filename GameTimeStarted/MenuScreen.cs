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
    public partial class MenuScreen : UserControl
    {

        public MenuScreen()
        {
            InitializeComponent();
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "GameScreen");

        }

        private void closeButton_Click(object sender, EventArgs e) /// close and save game
        {
            XmlWriter writer = XmlWriter.Create("HighScore.xml");

            //Write the root element
            writer.WriteStartElement("PlayerScore");

            foreach (int hs in GameForm.scoreList)
            {
 
                //Write sub-elements
                writer.WriteElementString("score", hs+"");

            }
            // end the element
            writer.WriteEndElement();
            // end the root element
            
            //Write the XML to file and close the writer
            writer.Close();


            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            
            GameForm.ChangeScreen(this, "HowScreen");
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            GameForm.ChangeScreen(this, "HighScreen");
        }
    }
}
