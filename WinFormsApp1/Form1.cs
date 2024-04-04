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
            wyœwietlacz.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void wyœwietlacz_TextChanged(object sender, EventArgs e)
        {
            if (wyœwietlacz.Text == "") wyœwietlacz.Text = "0";
            if (wyœwietlacz.Text.Length >= 10)
            {
                //wyœwietlacz.Text.Remove(7);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "1" : "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "2" : "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "3" : "3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "4" : "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "5" : "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "6" : "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "7" : "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "8" : "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = ((wyœwietlacz.Text != "0") ? wyœwietlacz.Text + "9" : "9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (wyœwietlacz.Text != "0") wyœwietlacz.Text += "0";
        }

        private void delate_Click(object sender, EventArgs e)
        {
            if (wyœwietlacz.Text.Length >= 1)
                wyœwietlacz.Text = wyœwietlacz.Text.Remove(wyœwietlacz.Text.Length - 1);
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            if (!wyœwietlacz.Text.Contains(","))
            {
                wyœwietlacz.Text += ",";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            wyœwietlacz.Text = "";
            a = 0;
            b = 0;
            symbol = '+';
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try { 
            if (double.Parse(wyœwietlacz.Text) != 0)
            a = double.Parse(wyœwietlacz.Text);
            symbol = '+';
            wyœwietlacz.Text = "";
            }
            catch (FormatException)
            {
                wyœwietlacz.Text = "0";
            }
        }
        private void equal_Click(object sender, EventArgs e)
        {
            
            try {
                
                switch (symbol)
                {
                    case '+':
                        wyœwietlacz.Text = (a + double.Parse(wyœwietlacz.Text)) + "";
                        break;

                    case '-':
                        b = a;
                        a = double.Parse(wyœwietlacz.Text);
                        wyœwietlacz.Text = b - double.Parse(wyœwietlacz.Text) + "";
                        symbol = 'm';
                    break;

                    case 'm':
                        wyœwietlacz.Text = double.Parse(wyœwietlacz.Text) -a + "";
                        break;
                    case '*':
                        wyœwietlacz.Text = (a * double.Parse(wyœwietlacz.Text)) + "";
                        break;
                    case '/':
                        if (double.Parse(wyœwietlacz.Text) == 0)
                        {
                            wyœwietlacz.Text = "Nie dziel przez 0";
                        }
                        else
                        {
                            b = double.Parse(wyœwietlacz.Text);
                            wyœwietlacz.Text = (a/b) + "";
                            symbol = 'd';
                        }
                        break;
                    case 'd':
                        wyœwietlacz.Text = double.Parse(wyœwietlacz.Text) / b + "";
                        break;
                }
            }
            catch (FormatException)
            {
                wyœwietlacz.Text = "0";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wyœwietlacz.Text) != 0)
                    a = double.Parse(wyœwietlacz.Text);
                wyœwietlacz.Text = "";
                symbol = '-';
            }
            catch (FormatException)
            {
                wyœwietlacz.Text = "0";
            }
        }

        private void times_Click(object sender, EventArgs e)
        {
            try { 
            if (double.Parse(wyœwietlacz.Text) != 0)
                a = double.Parse(wyœwietlacz.Text);
            wyœwietlacz.Text = "";
            symbol = '*';
            }
            catch (FormatException)
            {
                wyœwietlacz.Text = "";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wyœwietlacz.Text) != 0)
                {
                    a = double.Parse(wyœwietlacz.Text);
                };
                wyœwietlacz.Text = "";
                symbol = '/';
            }
            catch (FormatException)
            {
                wyœwietlacz.Text = "0";
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wyœwietlacz.Text) > 0)
                {
                    wyœwietlacz.Text = Math.Sqrt(double.Parse(wyœwietlacz.Text)) + "";
                }
                else
                {
                    wyœwietlacz.Text = "Liczba jest ujemna";
                }
            }
            catch (FormatException)
            {
                wyœwietlacz.Text = "0";
            }

        }

        private void inverse_Click(object sender, EventArgs e)
        {
            try
            {
                wyœwietlacz.Text = 1 / double.Parse(wyœwietlacz.Text) + "";
            }
            catch (FormatException)
            {
                wyœwietlacz.Text = "0";
            }
        }

        private void changesign_Click(object sender, EventArgs e)
        {
            try { 
                if(double.Parse(wyœwietlacz.Text)!= 0)
            wyœwietlacz.Text = -1 * double.Parse(wyœwietlacz.Text) + "";
            }
            catch (FormatException)
        {
                wyœwietlacz.Text = "0";
            }
        }

        
}
}