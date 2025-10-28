using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesAssignment
{
    public partial class FormAddResourses : Form
    {
        public FormAddResourses()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStrawberry_Click(object sender, EventArgs e)
        {
            imgstrawberry.Image = Properties.Resources.Strawberry;
        }

        private void btnBlueberry_Click(object sender, EventArgs e)
        {
             imgstrawberry.Image = Properties.Resources.BlueBerry;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imgstrawberry.Image = Properties.Resources.Pineapple;
        }
    }
}
