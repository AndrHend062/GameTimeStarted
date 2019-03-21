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
    public partial class EndScreen : UserControl
    {
       

        public EndScreen()
        {
            InitializeComponent();
            
            scoreLabel.Text = "YOUR SCORE \n" + GameForm.score;
            
            scoreLabel.Location = new Point((Width - scoreLabel.Width) / 2, 300);
            GameOverlabel.Location = new Point((Width - GameOverlabel.Width) / 2, 50);

            OnStart();
        }
        public void OnStart()
        {
           
            //foreach (XmlNode n in scoreList)
            //{
            //    if (n.InnerText == "Chris")

            //    {
            //        n.InnerText = "Howard";
            //    }
            //    else
            //    {
            //        n.InnerText = "Chris";
            //    }
            //}
          
            GameForm.scoreList.Add(GameForm.score);
            GameForm.scoreList.Sort();
            GameForm.scoreList.Reverse();
            GameForm.score = 0;
            if (GameForm.scoreList.Count > 10)
            {
                for(int i=10; i > 15; i++)
                {
                    GameForm.scoreList.RemoveAt(i);

                    if (GameForm.scoreList.Count < 11)
                    {break;}
                    
                }
            }

        }
        private void menuButton_Click(object sender, EventArgs e)
        {
         
            GameForm.ChangeScreen(this, "MenuScreen");
        }
    }
}
