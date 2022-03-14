using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mems
{
    public partial class Mems : Form
    {
        public Mems()
        {
            InitializeComponent();
        }

        private void opinion_Click(object sender, EventArgs e)
        {
            Opin Opin = new Opin();
            Opin.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SocOpinion_Click(object sender, EventArgs e)
        {
            SocRating soc = new SocRating();
            soc.ShowDialog();
        }
    }
}
