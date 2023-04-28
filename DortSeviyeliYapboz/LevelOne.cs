using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortSeviyeliYapboz
{
    public partial class LevelOne : Form
    {
        Random random = new Random();
        ArrayList locations = new ArrayList();
        int score;
        public LevelOne()
        {
            InitializeComponent();
            foreach (Button btn in panelLevelOne.Controls)
            {
                btn.Enabled = false;
                locations.Add(btn.Location);
                btn.Tag = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panelLevelOne.Controls)
            {
                btn.Enabled = false;
                btn.Tag = false;
            }
            buttonStart.Enabled = false;
            MixButtons();
            ButtonEnabledControl();
            score = 0;
        }
        private void MoveButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point temp = btn.Location;
            btn.Location = button9.Location;
            button9.Location = temp;
            ButtonEnabledControl();
            ButtonLocationControl();
            ChangeScore();
        }
        private void ButtonEnabledControl()
        {
            foreach (Button btn in panelLevelOne.Controls)
            {
                btn.Enabled = false;
                if(btn.Location.X + 75 == button9.Location.X && btn.Location.Y == button9.Location.Y)
                {
                    btn.Enabled = true;
                }
                else if (btn.Location.X - 75 == button9.Location.X && btn.Location.Y == button9.Location.Y)
                {
                    btn.Enabled = true;
                }
                else if (btn.Location.X == button9.Location.X && btn.Location.Y + 81 == button9.Location.Y)
                {
                    btn.Enabled = true;
                }
                else if (btn.Location.X == button9.Location.X && btn.Location.Y - 81 == button9.Location.Y)
                {
                    btn.Enabled = true;
                }
            }
        }
        private void MixButtons()
        {
            ArrayList temp = new ArrayList();
            temp = (ArrayList)locations.Clone();
            foreach (Button btn in panelLevelOne.Controls)
            {
                int i = random.Next(0, temp.Count);
                btn.Location = (Point)temp[i];
                temp.RemoveAt(i);
            }
        }
        private void ButtonLocationControl()
        {
            int counter = 0;

            for (int i = 0; i< locations.Count; i++)
            {
               if (panelLevelOne.Controls[i].Location.Equals(locations[i]) && panelLevelOne.Controls[i] != button9)
                {
                    panelLevelOne.Controls[i].BackColor= Color.Green;
                    panelLevelOne.Controls[i].Tag = true;
                }
                else
                {
                    panelLevelOne.Controls[i].BackColor = Color.White;
                    panelLevelOne.Controls[i].Tag= false;
                }
            }
            for (int i = 0; i < panelLevelOne.Controls.Count; i++)
            {
                
                if ((bool)panelLevelOne.Controls[i].Tag)
                {
                    counter++;
                }
            }
            if (counter == panelLevelOne.Controls.Count-1)
            { 
                MessageBox.Show("Winner");
                foreach (Button btn in panelLevelOne.Controls)
                {
                    btn.Enabled = false;
                }
                buttonStart.Enabled= true;
            }
        }
        private void ChangeScore()
        {
            labelMove.Text = $"Move: {++score}";
        }
    }
}
