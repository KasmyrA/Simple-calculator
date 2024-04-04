using System.Data.SqlTypes;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;   
        char symbol = '+';
        public Form1()
        {
            InitializeComponent();
            wy�wietlacz.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void wy�wietlacz_TextChanged(object sender, EventArgs e)
        {
            if (wy�wietlacz.Text == "") wy�wietlacz.Text = "0";
            if (wy�wietlacz.Text.Length >= 10)
            {
                //wy�wietlacz.Text.Remove(7);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "1" : "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "2" : "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "3" : "3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "4" : "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "5" : "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "6" : "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "7" : "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "8" : "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = ((wy�wietlacz.Text != "0") ? wy�wietlacz.Text + "9" : "9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (wy�wietlacz.Text != "0") wy�wietlacz.Text += "0";
        }

        private void delate_Click(object sender, EventArgs e)
        {
            if (wy�wietlacz.Text.Length >= 1)
                wy�wietlacz.Text = wy�wietlacz.Text.Remove(wy�wietlacz.Text.Length - 1);
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            if (!wy�wietlacz.Text.Contains(","))
            {
                wy�wietlacz.Text += ",";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            wy�wietlacz.Text = "";
            a = 0;
            b = 0;
            symbol = '+';
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try { 
            if (double.Parse(wy�wietlacz.Text) != 0)
            a = double.Parse(wy�wietlacz.Text);
            symbol = '+';
            wy�wietlacz.Text = "";
            }
            catch (FormatException)
            {
                wy�wietlacz.Text = "0";
            }
        }
        private void equal_Click(object sender, EventArgs e)
        {
            
            try {
                
                switch (symbol)
                {
                    case '+':
                        wy�wietlacz.Text = (a + double.Parse(wy�wietlacz.Text)) + "";
                        break;

                    case '-':
                        b = a;
                        a = double.Parse(wy�wietlacz.Text);
                        wy�wietlacz.Text = b - double.Parse(wy�wietlacz.Text) + "";
                        symbol = 'm';
                    break;

                    case 'm':
                        wy�wietlacz.Text = double.Parse(wy�wietlacz.Text) -a + "";
                        break;
                    case '*':
                        wy�wietlacz.Text = (a * double.Parse(wy�wietlacz.Text)) + "";
                        break;
                    case '/':
                        if (double.Parse(wy�wietlacz.Text) == 0)
                        {
                            wy�wietlacz.Text = "Nie dziel przez 0";
                        }
                        else
                        {
                            b = double.Parse(wy�wietlacz.Text);
                            wy�wietlacz.Text = (a/b) + "";
                            symbol = 'd';
                        }
                        break;
                    case 'd':
                        wy�wietlacz.Text = double.Parse(wy�wietlacz.Text) / b + "";
                        break;
                }
            }
            catch (FormatException)
            {
                wy�wietlacz.Text = "0";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wy�wietlacz.Text) != 0)
                    a = double.Parse(wy�wietlacz.Text);
                wy�wietlacz.Text = "";
                symbol = '-';
            }
            catch (FormatException)
            {
                wy�wietlacz.Text = "0";
            }
        }

        private void times_Click(object sender, EventArgs e)
        {
            try { 
            if (double.Parse(wy�wietlacz.Text) != 0)
                a = double.Parse(wy�wietlacz.Text);
            wy�wietlacz.Text = "";
            symbol = '*';
            }
            catch (FormatException)
            {
                wy�wietlacz.Text = "";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wy�wietlacz.Text) != 0)
                {
                    a = double.Parse(wy�wietlacz.Text);
                };
                wy�wietlacz.Text = "";
                symbol = '/';
            }
            catch (FormatException)
            {
                wy�wietlacz.Text = "0";
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wy�wietlacz.Text) > 0)
                {
                    wy�wietlacz.Text = Math.Sqrt(double.Parse(wy�wietlacz.Text)) + "";
                }
                else
                {
                    wy�wietlacz.Text = "Liczba jest ujemna";
                }
            }
            catch (FormatException)
            {
                wy�wietlacz.Text = "0";
            }

        }

        private void inverse_Click(object sender, EventArgs e)
        {
            try
            {
                wy�wietlacz.Text = 1 / double.Parse(wy�wietlacz.Text) + "";
            }
            catch (FormatException)
            {
                wy�wietlacz.Text = "0";
            }
        }

        private void changesign_Click(object sender, EventArgs e)
        {
            try { 
                if(double.Parse(wy�wietlacz.Text)!= 0)
            wy�wietlacz.Text = -1 * double.Parse(wy�wietlacz.Text) + "";
            }
            catch (FormatException)
        {
                wy�wietlacz.Text = "0";
            }
        }

        
}
}