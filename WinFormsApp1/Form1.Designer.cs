namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            equal = new Button();
            wyświetlacz = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            delate = new Button();
            plus = new Button();
            minus = new Button();
            times = new Button();
            divide = new Button();
            button_comma = new Button();
            changesign = new Button();
            inverse = new Button();
            square = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // equal
            // 
            equal.BackColor = SystemColors.Control;
            equal.BackgroundImage = (Image)resources.GetObject("equal.BackgroundImage");
            equal.BackgroundImageLayout = ImageLayout.Center;
            equal.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Point);
            equal.Location = new Point(289, 315);
            equal.Name = "equal";
            equal.Size = new Size(182, 162);
            equal.TabIndex = 0;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // wyświetlacz
            // 
            wyświetlacz.BackColor = SystemColors.ControlLight;
            wyświetlacz.Cursor = Cursors.No;
            wyświetlacz.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            wyświetlacz.Location = new Point(-1, 3);
            wyświetlacz.MaxLength = 3300000;
            wyświetlacz.Name = "wyświetlacz";
            wyświetlacz.ReadOnly = true;
            wyświetlacz.Size = new Size(480, 61);
            wyświetlacz.TabIndex = 1;
            wyświetlacz.TextAlign = HorizontalAlignment.Right;
            wyświetlacz.WordWrap = false;
            wyświetlacz.TextChanged += wyświetlacz_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(7, 147);
            button1.Name = "button1";
            button1.Size = new Size(88, 78);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(101, 147);
            button2.Name = "button2";
            button2.Size = new Size(88, 78);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(195, 147);
            button3.Name = "button3";
            button3.Size = new Size(88, 78);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(7, 231);
            button4.Name = "button4";
            button4.Size = new Size(88, 78);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(101, 231);
            button5.Name = "button5";
            button5.Size = new Size(88, 78);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(195, 231);
            button6.Name = "button6";
            button6.Size = new Size(88, 78);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.BackgroundImageLayout = ImageLayout.Center;
            button7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(7, 315);
            button7.Name = "button7";
            button7.Size = new Size(88, 78);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.BackgroundImageLayout = ImageLayout.Center;
            button8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(101, 315);
            button8.Name = "button8";
            button8.Size = new Size(88, 78);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Control;
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(195, 315);
            button9.Name = "button9";
            button9.Size = new Size(88, 78);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.Control;
            button0.BackgroundImage = (Image)resources.GetObject("button0.BackgroundImage");
            button0.BackgroundImageLayout = ImageLayout.Center;
            button0.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(12, 399);
            button0.Name = "button0";
            button0.Size = new Size(177, 78);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // delate
            // 
            delate.BackColor = SystemColors.Control;
            delate.BackgroundImage = (Image)resources.GetObject("delate.BackgroundImage");
            delate.BackgroundImageLayout = ImageLayout.Center;
            delate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            delate.Location = new Point(289, 63);
            delate.Name = "delate";
            delate.Size = new Size(88, 78);
            delate.TabIndex = 12;
            delate.Text = "⌫";
            delate.UseVisualStyleBackColor = false;
            delate.Click += delate_Click;
            // 
            // plus
            // 
            plus.BackColor = SystemColors.Control;
            plus.BackgroundImage = (Image)resources.GetObject("plus.BackgroundImage");
            plus.BackgroundImageLayout = ImageLayout.Center;
            plus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            plus.Location = new Point(289, 231);
            plus.Name = "plus";
            plus.Size = new Size(88, 78);
            plus.TabIndex = 13;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.BackColor = SystemColors.Control;
            minus.BackgroundImage = (Image)resources.GetObject("minus.BackgroundImage");
            minus.BackgroundImageLayout = ImageLayout.Center;
            minus.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            minus.Location = new Point(289, 147);
            minus.Name = "minus";
            minus.Size = new Size(88, 78);
            minus.TabIndex = 14;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // times
            // 
            times.BackColor = SystemColors.Control;
            times.BackgroundImage = (Image)resources.GetObject("times.BackgroundImage");
            times.BackgroundImageLayout = ImageLayout.Center;
            times.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            times.Location = new Point(195, 63);
            times.Name = "times";
            times.Size = new Size(88, 78);
            times.TabIndex = 15;
            times.Text = "×";
            times.UseVisualStyleBackColor = false;
            times.Click += times_Click;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.Control;
            divide.BackgroundImage = (Image)resources.GetObject("divide.BackgroundImage");
            divide.BackgroundImageLayout = ImageLayout.Center;
            divide.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            divide.Location = new Point(101, 63);
            divide.Name = "divide";
            divide.Size = new Size(88, 78);
            divide.TabIndex = 16;
            divide.Text = "÷";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // button_comma
            // 
            button_comma.BackColor = SystemColors.Control;
            button_comma.BackgroundImage = (Image)resources.GetObject("button_comma.BackgroundImage");
            button_comma.BackgroundImageLayout = ImageLayout.Center;
            button_comma.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button_comma.Location = new Point(195, 399);
            button_comma.Name = "button_comma";
            button_comma.Size = new Size(88, 78);
            button_comma.TabIndex = 17;
            button_comma.Text = ",";
            button_comma.UseVisualStyleBackColor = false;
            button_comma.Click += button_comma_Click;
            // 
            // changesign
            // 
            changesign.BackColor = SystemColors.Control;
            changesign.BackgroundImage = (Image)resources.GetObject("changesign.BackgroundImage");
            changesign.BackgroundImageLayout = ImageLayout.Center;
            changesign.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            changesign.Location = new Point(383, 231);
            changesign.Name = "changesign";
            changesign.Size = new Size(88, 78);
            changesign.TabIndex = 18;
            changesign.Text = "±";
            changesign.UseVisualStyleBackColor = false;
            changesign.Click += changesign_Click;
            // 
            // inverse
            // 
            inverse.BackColor = SystemColors.Control;
            inverse.BackgroundImage = (Image)resources.GetObject("inverse.BackgroundImage");
            inverse.BackgroundImageLayout = ImageLayout.Center;
            inverse.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            inverse.Location = new Point(383, 147);
            inverse.Name = "inverse";
            inverse.Size = new Size(88, 78);
            inverse.TabIndex = 19;
            inverse.Text = "1/x";
            inverse.UseVisualStyleBackColor = false;
            inverse.Click += inverse_Click;
            // 
            // square
            // 
            square.BackColor = SystemColors.Control;
            square.BackgroundImage = (Image)resources.GetObject("square.BackgroundImage");
            square.BackgroundImageLayout = ImageLayout.Center;
            square.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            square.Location = new Point(7, 63);
            square.Name = "square";
            square.Size = new Size(88, 78);
            square.TabIndex = 20;
            square.Text = "√x ";
            square.UseVisualStyleBackColor = false;
            square.Click += square_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.Control;
            clear.BackgroundImage = (Image)resources.GetObject("clear.BackgroundImage");
            clear.BackgroundImageLayout = ImageLayout.Center;
            clear.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            clear.Location = new Point(383, 63);
            clear.Name = "clear";
            clear.Size = new Size(88, 78);
            clear.TabIndex = 21;
            clear.Text = "CE";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(476, 480);
            Controls.Add(clear);
            Controls.Add(square);
            Controls.Add(inverse);
            Controls.Add(changesign);
            Controls.Add(button_comma);
            Controls.Add(divide);
            Controls.Add(times);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(delate);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(wyświetlacz);
            Controls.Add(equal);
            Name = "Form1";
            Text = "Kalkulator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button equal;
        private TextBox wyświetlacz;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button delate;
        private Button plus;
        private Button minus;
        private Button times;
        private Button divide;
        private Button button_comma;
        private Button changesign;
        private Button inverse;
        private Button square;
        private Button clear;
    }
}