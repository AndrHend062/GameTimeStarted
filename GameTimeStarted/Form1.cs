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
    {   public static List<int> scoreList = new List<int>();
        XmlReader reader;
        XmlWriter writer;
        public static int score = 0;
        public GameForm()
        {
            InitializeComponent();
            try
            {
                reader = XmlReader.Create("HighScore.xml"); // make reader 
            }
            catch { }

        }

 
        private void GameForm_Load(object sender, EventArgs e)
        {
            try
            {

                while (reader.Read())

                {
                    if (reader.NodeType == XmlNodeType.Text) // read
                    {
                        scoreList.Add(Convert.ToInt16(reader.Value));
                    }

                }
                reader.Close();
            }
            catch { }
            
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            Form f = FindForm();
            MenuScreen ns =new MenuScreen();
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);
            ns.Focus();
            Cursor.Hide();
        }
        public static void ChangeScreen(UserControl current, string next)
        {
            //f is set to the form that the current control is on
            Form f = current.FindForm();
            f.Controls.Remove(current);
            UserControl ns = null;

            //switches screen
            switch (next)
            {
                case "MenuScreen":
                    ns = new MenuScreen();
                    break;
                case "GameScreen":
                    ns = new GameScreen();
                    break;
                case "ScoreScreen":
                    ns = new HighScreen();
                    break;
                case "HowScreen":
                    ns = new HowScreen();
                    break;
                case "HighScreen":
                    ns = new HighScreen();
                    break;
                case "EndScreen":
                    ns = new EndScreen();
                    break;
            }

            //centres on the screen
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);

            f.Controls.Add(ns);
            ns.Focus();
        }
    }
}
