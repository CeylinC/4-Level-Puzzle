using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLevelOne_Click(object sender, EventArgs e)
        {
            LevelOne lvlOne = new LevelOne();
            lvlOne.Show();
        }
        private void buttonLevelTwo_Click(object sender, EventArgs e)
        {
            LevelTwo lvlTwo= new LevelTwo();
            lvlTwo.Show();
        }
        private void buttonLevelThree_Click(object sender, EventArgs e)
        {
            LevelThree lvlThree = new LevelThree();
            lvlThree.Show();
        }
        private void buttonLevelFour_Click(object sender, EventArgs e)
        {
            LevelFour lvlFour = new LevelFour();
            lvlFour.Show();
        }
    }
}
