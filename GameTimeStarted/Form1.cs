using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace GameTimeStarted
{
    public partial class GameForm : Form
    {   List<int> HighScores = new List<int>();
        XmlReader reader;
        XmlWriter writer;
        public static int score = 0;
        public GameForm()
        {
            InitializeComponent();
            try
            {
                reader = XmlReader.Create("Resources/HighScore.xml");
                writer = XmlWriter.Create("Resources/HighScore.xml");
            }
            catch { }

        }

        
        public void ScoreReset()
        { score = 0;}

        private void GameForm_Load(object sender, EventArgs e)
        {
            //Write the root element 

           // writer.WriteStartElement("HighScore");

            //Start an element 

            writer.WriteStartElement("playerScore");



            //Write sub-elements 

            writer.WriteElementString("Score", "1313");

            
            // end the element 

            writer.WriteEndElement();

            // end the root element 

            writer.WriteEndElement();
            
            //Write the XML to file and close the writer 

            writer.Close();

            while (reader.Read())

            { 
                if (reader.NodeType == XmlNodeType.Text) // read
                {
                 HighScores.Add(Convert.ToInt16(reader.Value));
                }

            }

            reader.Close();

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
