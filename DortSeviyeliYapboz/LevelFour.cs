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
using Image = System.Drawing.Image;

namespace DortSeviyeliYapboz
{
    public partial class LevelFour : Form
    {
        Random random = new Random();
        ArrayList locations = new ArrayList();
        ArrayList images = new ArrayList();
        int score;
        Image orginal = Image.FromFile(@"C:\Users\ailes\Downloads\omori.jpeg");
        public LevelFour()
        {
            InitializeComponent();
            foreach (Button btn in panelLevelFour.Controls)
            {
                btn.Enabled = false;
                locations.Add(btn.Location);
                btn.Tag = false;
            }
            cropImageTomages(orginal, 400, 400);
            AddImagesToButtons(images);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panelLevelFour.Controls)
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
            foreach (Button btn in panelLevelFour.Controls)
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
            foreach (Button btn in panelLevelFour.Controls)
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
                if (panelLevelFour.Controls[i].Location.Equals(locations[i]) && panelLevelFour.Controls[i] != button16)
                {
                    panelLevelFour.Controls[i].BackColor = Color.Green;
                    panelLevelFour.Controls[i].Tag = true;
                }
                else
                {
                    panelLevelFour.Controls[i].BackColor = Color.White;
                    panelLevelFour.Controls[i].Tag = false;
                }
            }
            for (int i = 0; i < panelLevelFour.Controls.Count; i++)
            {

                if ((bool)panelLevelFour.Controls[i].Tag)
                {
                    counter++;
                }
            }
            if (counter == panelLevelFour.Controls.Count - 1)
            {
                MessageBox.Show("Winner");
                foreach (Button btn in panelLevelFour.Controls)
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
        private void AddImagesToButtons(ArrayList images)
        {
            button1.Image = (Image)images[0];
            button2.Image = (Image)images[1];
            button3.Image = (Image)images[2];
            button4.Image = (Image)images[3];
            button5.Image = (Image)images[4];
            button6.Image = (Image)images[5];
            button7.Image = (Image)images[6];
            button8.Image = (Image)images[7];
            button9.Image = (Image)images[8];
            button10.Image = (Image)images[9];
            button11.Image = (Image)images[10];
            button12.Image = (Image)images[11];
            button13.Image = (Image)images[12];
            button14.Image = (Image)images[13];
            button15.Image = (Image)images[14];
        }
        private void cropImageTomages(Image orginal, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(orginal, 0, 0, w, h);
            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 15; x++)
            {
                Bitmap piece = new Bitmap(100, 100);

                for (int i = 0; i < 100; i++)
                    for (int j = 0; j < 100; j++)
                        piece.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);

                movr += 100;

                if (movr == 400)
                {
                    movr = 0;
                    movd += 100;
                }
            }

        }
    }
}
