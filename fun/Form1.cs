using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fun
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button_plot_Click(object sender, EventArgs e)
		{
			if (numericUpDown_from.Value == numericUpDown_to.Value)
			{
				string message = "x1 == x2";
				DialogResult result = MessageBox.Show(message, "Plot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else if (comboBox_fun.SelectedItem == null)
			{
				string message = "no func";
				DialogResult result = MessageBox.Show(message, "Plot", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			else
			{
				int w = pictureBox.Width;
				int h = pictureBox.Height;
				Bitmap im = new Bitmap(w, h);
				Graphics img = Graphics.FromImage(im);
				img.FillRectangle(Brushes.White, 0, 0, w, h);
				pictureBox.Image = im;

				this.Text = comboBox_fun.Text;
			}
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			if (pictureBox.Image != null)
			{
				pictureBox.Image.Dispose();
				pictureBox.Image = null;
			}
			numericUpDown_from.Value = 0;
			numericUpDown_to.Value = 0;
			comboBox_fun.SelectedItem = null;
				this.Text = "Plot";
		}
	}
}
