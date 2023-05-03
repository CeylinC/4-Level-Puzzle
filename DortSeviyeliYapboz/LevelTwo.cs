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
    public partial class LevelTwo : Form
    {
        Random random = new Random();
        ArrayList locations = new ArrayList();
        ArrayList images = new ArrayList();
        int score;
        Image orginal = Image.FromFile(Application.StartupPath + @"\picture.jpg");
        public LevelTwo()
        {
            InitializeComponent();
            foreach (Button btn in panelLevelTwo.Controls)
            {
                btn.Enabled = false;
                locations.Add(btn.Location);
                btn.Tag = false;
            }
            cropImageTomages(orginal, 300, 300);
            AddImagesToButtons(images);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panelLevelTwo.Controls)
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
            foreach (Button btn in panelLevelTwo.Controls)
            {
                btn.Enabled = false;
                if (btn.Location.X + 75 == button9.Location.X && btn.Location.Y == button9.Location.Y)
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
            foreach (Button btn in panelLevelTwo.Controls)
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
                if (panelLevelTwo.Controls[i].Location.Equals(locations[i]) && panelLevelTwo.Controls[i] != button9)
                {
                    panelLevelTwo.Controls[i].Tag = true;
                }
                else
                {
                    panelLevelTwo.Controls[i].Tag = false;
                }
            }
            for (int i = 0; i < panelLevelTwo.Controls.Count; i++)
            {

                if ((bool)panelLevelTwo.Controls[i].Tag)
                {
                    counter++;
                }
            }
            if (counter == panelLevelTwo.Controls.Count - 1)
            {
                MessageBox.Show("Winner");
                foreach (Button btn in panelLevelTwo.Controls)
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
        }
        private void cropImageTomages(Image orginal, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(orginal, 0, 0, w, h);
            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 8; x++)
            {
                Bitmap piece = new Bitmap(100, 100);

                for (int i = 0; i < 100; i++)
                    for (int j = 0; j < 100; j++)
                        piece.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);

                movr += 100;

                if (movr == 300)
                {
                    movr = 0;
                    movd += 100;
                }
            }

        }
    }
}

