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
    public partial class LevelThree : Form
    {
        Random random = new Random();
        ArrayList locations = new ArrayList();
        int score;
        public LevelThree()
        {
            InitializeComponent();
            foreach (Button btn in panelLevelThree.Controls)
            {
                btn.Enabled = false;
                locations.Add(btn.Location);
                btn.Tag = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panelLevelThree.Controls)
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
            btn.Location = button16.Location;
            button16.Location = temp;
            ButtonEnabledControl();
            ButtonLocationControl();
            ChangeScore();
        }
        private void ButtonEnabledControl()
        {
            foreach (Button btn in panelLevelThree.Controls)
            {
                btn.Enabled = false;
                if (btn.Location.X + 75 == button16.Location.X && btn.Location.Y == button16.Location.Y)
                {
                    btn.Enabled = true;
                }
                else if (btn.Location.X - 75 == button16.Location.X && btn.Location.Y == button16.Location.Y)
                {
                    btn.Enabled = true;
                }
                else if (btn.Location.X == button16.Location.X && btn.Location.Y + 81 == button16.Location.Y)
                {
                    btn.Enabled = true;
                }
                else if (btn.Location.X == button16.Location.X && btn.Location.Y - 81 == button16.Location.Y)
                {
                    btn.Enabled = true;
                }
            }
        }
        private void MixButtons()
        {
            ArrayList temp = new ArrayList();
            temp = (ArrayList)locations.Clone();
            foreach (Button btn in panelLevelThree.Controls)
            {
                int i = random.Next(0, temp.Count);
                btn.Location = (Point)temp[i];
                temp.RemoveAt(i);
            }
        }
        private void ButtonLocationControl()
        {
            int counter = 0;

            for (int i = 0; i < locations.Count; i++)
            {
                if (panelLevelThree.Controls[i].Location.Equals(locations[i]) && panelLevelThree.Controls[i] != button16)
                {
                    panelLevelThree.Controls[i].BackColor = Color.Green;
                    panelLevelThree.Controls[i].Tag = true;
                }
                else
                {
                    panelLevelThree.Controls[i].BackColor = Color.White;
                    panelLevelThree.Controls[i].Tag = false;
                }
            }
            for (int i = 0; i < panelLevelThree.Controls.Count; i++)
            {

                if ((bool)panelLevelThree.Controls[i].Tag)
                {
                    counter++;
                }
            }
            if (counter == panelLevelThree.Controls.Count - 1)
            {
                MessageBox.Show("Winner");
                foreach (Button btn in panelLevelThree.Controls)
                {
                    btn.Enabled = false;
                }
                buttonStart.Enabled = true;
            }
        }
        private void ChangeScore()
        {
            labelMove.Text = $"Move: {++score}";
        }

    }
}
