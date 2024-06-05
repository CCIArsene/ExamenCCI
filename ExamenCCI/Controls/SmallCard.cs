using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenCCI.Controls
{
    public partial class SmallCard : UserControl
    {
        public SmallCard()
        {
            InitializeComponent();
        }

        public void txtName_TextChanged(object sender, EventArgs e, string _name)
        {
            txtName.Text = _name;
        }

        public void pictureBox1_Click(object sender, EventArgs e, Image _image)
        {
            pictureBox1.Image = _image;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A l'aide");
        }
    }
}
