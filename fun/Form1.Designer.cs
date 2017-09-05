namespace fun
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_from = new System.Windows.Forms.Label();
			this.label_to = new System.Windows.Forms.Label();
			this.button_plot = new System.Windows.Forms.Button();
			this.comboBox_fun = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label_fun = new System.Windows.Forms.Label();
			this.numericUpDown_from = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_to = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_from)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_to)).BeginInit();
			this.SuspendLayout();
			// 
			// label_from
			// 
			this.label_from.AutoSize = true;
			this.label_from.Location = new System.Drawing.Point(446, 15);
			this.label_from.Name = "label_from";
			this.label_from.Size = new System.Drawing.Size(18, 13);
			this.label_from.TabIndex = 3;
			this.label_from.Text = "x1";
			// 
			// label_to
			// 
			this.label_to.AutoSize = true;
			this.label_to.Location = new System.Drawing.Point(444, 45);
			this.label_to.Name = "label_to";
			this.label_to.Size = new System.Drawing.Size(18, 13);
			this.label_to.TabIndex = 4;
			this.label_to.Text = "x2";
			// 
			// button_plot
			// 
			this.button_plot.Location = new System.Drawing.Point(476, 310);
			this.button_plot.Name = "button_plot";
			this.button_plot.Size = new System.Drawing.Size(75, 23);
			this.button_plot.TabIndex = 5;
			this.button_plot.Text = "Plot";
			this.button_plot.UseVisualStyleBackColor = true;
			// 
			// comboBox_fun
			// 
			this.comboBox_fun.FormattingEnabled = true;
			this.comboBox_fun.Items.AddRange(new object[] {
            "SIN",
            "COS",
            "SQRT",
            "X^2",
            "X^3"});
			this.comboBox_fun.Location = new System.Drawing.Point(457, 117);
			this.comboBox_fun.Name = "comboBox_fun";
			this.comboBox_fun.Size = new System.Drawing.Size(121, 21);
			this.comboBox_fun.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pictureBox1.Location = new System.Drawing.Point(12, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(426, 350);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label_fun
			// 
			this.label_fun.AutoSize = true;
			this.label_fun.Location = new System.Drawing.Point(464, 101);
			this.label_fun.Name = "label_fun";
			this.label_fun.Size = new System.Drawing.Size(48, 13);
			this.label_fun.TabIndex = 8;
			this.label_fun.Text = "Function";
			// 
			// numericUpDown_from
			// 
			this.numericUpDown_from.Location = new System.Drawing.Point(470, 13);
			this.numericUpDown_from.Name = "numericUpDown_from";
			this.numericUpDown_from.Size = new System.Drawing.Size(108, 20);
			this.numericUpDown_from.TabIndex = 10;
			// 
			// numericUpDown_to
			// 
			this.numericUpDown_to.Location = new System.Drawing.Point(470, 39);
			this.numericUpDown_to.Name = "numericUpDown_to";
			this.numericUpDown_to.Size = new System.Drawing.Size(108, 20);
			this.numericUpDown_to.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 370);
			this.Controls.Add(this.numericUpDown_to);
			this.Controls.Add(this.numericUpDown_from);
			this.Controls.Add(this.label_fun);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.comboBox_fun);
			this.Controls.Add(this.button_plot);
			this.Controls.Add(this.label_to);
			this.Controls.Add(this.label_from);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_from)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_to)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_from;
		private System.Windows.Forms.Label label_to;
		private System.Windows.Forms.Button button_plot;
		private System.Windows.Forms.ComboBox comboBox_fun;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label_fun;
		private System.Windows.Forms.NumericUpDown numericUpDown_from;
		private System.Windows.Forms.NumericUpDown numericUpDown_to;
	}
}

