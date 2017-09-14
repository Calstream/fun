using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace fun
{

    public partial class Form1 : Form
	{
        const int n_points = 100;
        delegate double function(double x);
        double[] array_x = new double[n_points];
        double[] array_y = new double[n_points];
        function f;

        public Form1()
		{
			InitializeComponent();
		}

		private void button_plot_Click(object sender, EventArgs e)
		{
			if (numericUpDown_from.Value >= numericUpDown_to.Value)
			{
				string message = "no";
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
				Graphics gr = Graphics.FromImage(im);
				//img.FillRectangle(Brushes.White, 0, 0, w, h);

                function fun = x => x;
                switch (comboBox_fun.SelectedIndex)
                {
                    case 0: //pow
                        fun = x => Math.Pow(x, (double)numericUpDown_pow.Value); 
                        break;
                    case 1: //lin
                        double a = (double)numericUpDown_lin_a.Value;
                        double b = (double)numericUpDown_lin_b.Value;
                        fun = x => a * x + b; 
                        break;
                    case 2: //sin 
                        fun = x => Math.Sin(x);
                        break;
                    case 3: //cos
                        fun = x => Math.Cos(x);
                        break;
                    case 4: //tan 
                        fun = x => Math.Tan(x);
                        break;
                    case 5: //round
                        fun = x => Math.Round(x);
                        break;
                    case 6: //exp
                        fun = x => Math.Exp(x);
                        break;
                    default:
                        DialogResult result = MessageBox.Show("?????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                }

                //________________
                fill_array(fun);
                float y_min = (float)array_y.Min();
                float y_max = (float)array_y.Max();

                float[] x_p = new float[n_points];
                for (int i = 0; i < n_points; i++)
                    x_p[i] = w / n_points * i;

                float y_diff = y_max - y_min;
                float y_step = h / y_diff;

                float[] y_p = new float[n_points];
                for (int i = 0; i < n_points; i++)
                    y_p[i] = (y_max - (float)array_y[i]) * y_step;

                Pen p = new Pen(Color.DeepSkyBlue, 2);
                    PointF[] pts = new PointF[array_x.GetLength(0)];

                    for (int i = 0; i < n_points; i++)
                    {
                        pts[i].X = x_p[i];
                        pts[i].Y = y_p[i];
                    }
                    gr.DrawCurve(p, pts, 0);
                //________________
                pictureBox.Image = im;
            }
                
				this.Text = comboBox_fun.Text;
			
		}

		private void fill_array(function f)
		{
            double x1 = (double)numericUpDown_from.Value;
            double x2 = (double)numericUpDown_to.Value;
            double step = (x2 - x1) / n_points;
            for (int i = 0; i < n_points; i++)
            {
                array_x[i] = x1 + step * i;
                array_y[i] = f(array_x[i]);
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

        private void comboBox_fun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_fun.SelectedIndex == 0)
            {
                numericUpDown_pow.Enabled = true;
                numericUpDown_lin_a.Enabled = false;
                numericUpDown_lin_b.Enabled = false;
            }
            else if (comboBox_fun.SelectedIndex == 1)
            {
                numericUpDown_lin_a.Enabled = true;
                numericUpDown_lin_b.Enabled = true;
                numericUpDown_pow.Enabled = false;
            }
            else
            {
                numericUpDown_pow.Enabled = false;
                numericUpDown_lin_a.Enabled = false;
                numericUpDown_lin_b.Enabled = false;
            }
        }
    }
}
