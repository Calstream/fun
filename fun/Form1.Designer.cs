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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label_fun = new System.Windows.Forms.Label();
            this.numericUpDown_from = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_to = new System.Windows.Forms.NumericUpDown();
            this.button_clear = new System.Windows.Forms.Button();
            this.numericUpDown_lin_a = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_lin_b = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_pow = new System.Windows.Forms.NumericUpDown();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_pow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lin_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lin_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pow)).BeginInit();
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
            this.button_plot.Location = new System.Drawing.Point(481, 302);
            this.button_plot.Name = "button_plot";
            this.button_plot.Size = new System.Drawing.Size(75, 23);
            this.button_plot.TabIndex = 5;
            this.button_plot.Text = "Plot";
            this.button_plot.UseVisualStyleBackColor = true;
            this.button_plot.Click += new System.EventHandler(this.button_plot_Click);
            // 
            // comboBox_fun
            // 
            this.comboBox_fun.FormattingEnabled = true;
            this.comboBox_fun.Items.AddRange(new object[] {
            "POW",
            "LIN",
            "SIN",
            "COS",
            "TAN",
            "ROUND",
            "EXP"});
            this.comboBox_fun.Location = new System.Drawing.Point(457, 117);
            this.comboBox_fun.Name = "comboBox_fun";
            this.comboBox_fun.Size = new System.Drawing.Size(121, 21);
            this.comboBox_fun.TabIndex = 6;
            this.comboBox_fun.SelectedIndexChanged += new System.EventHandler(this.comboBox_fun_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(426, 350);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
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
            this.numericUpDown_from.DecimalPlaces = 1;
            this.numericUpDown_from.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_from.Location = new System.Drawing.Point(470, 13);
            this.numericUpDown_from.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_from.Name = "numericUpDown_from";
            this.numericUpDown_from.Size = new System.Drawing.Size(108, 20);
            this.numericUpDown_from.TabIndex = 10;
            // 
            // numericUpDown_to
            // 
            this.numericUpDown_to.DecimalPlaces = 1;
            this.numericUpDown_to.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_to.Location = new System.Drawing.Point(470, 39);
            this.numericUpDown_to.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_to.Name = "numericUpDown_to";
            this.numericUpDown_to.Size = new System.Drawing.Size(108, 20);
            this.numericUpDown_to.TabIndex = 11;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(481, 335);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 12;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // numericUpDown_lin_a
            // 
            this.numericUpDown_lin_a.DecimalPlaces = 1;
            this.numericUpDown_lin_a.Enabled = false;
            this.numericUpDown_lin_a.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_lin_a.Location = new System.Drawing.Point(457, 174);
            this.numericUpDown_lin_a.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_lin_a.Name = "numericUpDown_lin_a";
            this.numericUpDown_lin_a.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_lin_a.TabIndex = 13;
            // 
            // numericUpDown_lin_b
            // 
            this.numericUpDown_lin_b.DecimalPlaces = 1;
            this.numericUpDown_lin_b.Enabled = false;
            this.numericUpDown_lin_b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_lin_b.Location = new System.Drawing.Point(523, 174);
            this.numericUpDown_lin_b.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_lin_b.Name = "numericUpDown_lin_b";
            this.numericUpDown_lin_b.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_lin_b.TabIndex = 14;
            // 
            // numericUpDown_pow
            // 
            this.numericUpDown_pow.Enabled = false;
            this.numericUpDown_pow.Location = new System.Drawing.Point(457, 227);
            this.numericUpDown_pow.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_pow.Name = "numericUpDown_pow";
            this.numericUpDown_pow.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_pow.TabIndex = 15;
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(454, 158);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(13, 13);
            this.label_a.TabIndex = 16;
            this.label_a.Text = "a";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(520, 158);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(13, 13);
            this.label_b.TabIndex = 17;
            this.label_b.Text = "b";
            // 
            // label_pow
            // 
            this.label_pow.AutoSize = true;
            this.label_pow.Location = new System.Drawing.Point(454, 211);
            this.label_pow.Name = "label_pow";
            this.label_pow.Size = new System.Drawing.Size(36, 13);
            this.label_pow.TabIndex = 18;
            this.label_pow.Text = "power";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 370);
            this.Controls.Add(this.label_pow);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.numericUpDown_pow);
            this.Controls.Add(this.numericUpDown_lin_b);
            this.Controls.Add(this.numericUpDown_lin_a);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.numericUpDown_to);
            this.Controls.Add(this.numericUpDown_from);
            this.Controls.Add(this.label_fun);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.comboBox_fun);
            this.Controls.Add(this.button_plot);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_from);
            this.Name = "Form1";
            this.Text = "Plot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lin_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lin_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_from;
		private System.Windows.Forms.Label label_to;
		private System.Windows.Forms.Button button_plot;
		private System.Windows.Forms.ComboBox comboBox_fun;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label label_fun;
		private System.Windows.Forms.NumericUpDown numericUpDown_from;
		private System.Windows.Forms.NumericUpDown numericUpDown_to;
		private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.NumericUpDown numericUpDown_lin_a;
        private System.Windows.Forms.NumericUpDown numericUpDown_lin_b;
        private System.Windows.Forms.NumericUpDown numericUpDown_pow;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_pow;
    }
}

