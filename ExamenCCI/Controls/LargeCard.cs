using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExamenCCI.Controls
{
    public partial class LargeCard : UserControl
    {
        public LargeCard()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e, Image _image)
        {
            pictureBox1.Image = _image;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void textBox4_TextChanged(object sender, EventArgs e, string _name)
        {
            
            textBoxName.Text = _name;
            
        }

        public void textBoxCountry_TextChanged(object sender, EventArgs e, string _country)
        {
            textBoxCountry.Text = _country;
        }

        public void textBoxGenre_TextChanged(object sender, EventArgs e, string _genre)
        {
            textBoxGenre.Text = _genre;
        }

        public void textBoxDate_TextChanged(object sender, EventArgs e, DateTime _date)
        {
            textBoxDate.Text = _date.ToString();
        }

        public void textBoxScene_TextChanged(object sender, EventArgs e, string _scene)
        {
            textBoxScene.Text = _scene;
        }

        public void textBoxDescription_TextChanged(object sender, EventArgs e, string _description)
        {
            textBoxDescription.Text = _description;
        }
    }
}
