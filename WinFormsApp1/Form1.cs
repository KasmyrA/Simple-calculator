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
            wyświetlacz.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void wyświetlacz_TextChanged(object sender, EventArgs e)
        {
            if (wyświetlacz.Text == "") wyświetlacz.Text = "0";
            if (wyświetlacz.Text.Length >= 10)
            {
                //wyświetlacz.Text.Remove(7);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "1" : "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "2" : "2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "3" : "3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "4" : "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "5" : "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "6" : "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "7" : "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "8" : "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = ((wyświetlacz.Text != "0") ? wyświetlacz.Text + "9" : "9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (wyświetlacz.Text != "0") wyświetlacz.Text += "0";
        }

        private void delate_Click(object sender, EventArgs e)
        {
            if (wyświetlacz.Text.Length >= 1)
                wyświetlacz.Text = wyświetlacz.Text.Remove(wyświetlacz.Text.Length - 1);
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            if (!wyświetlacz.Text.Contains(","))
            {
                wyświetlacz.Text += ",";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            wyświetlacz.Text = "";
            a = 0;
            b = 0;
            symbol = '+';
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try { 
            if (double.Parse(wyświetlacz.Text) != 0)
            a = double.Parse(wyświetlacz.Text);
            symbol = '+';
            wyświetlacz.Text = "";
            }
            catch (FormatException)
            {
                wyświetlacz.Text = "0";
            }
        }
        private void equal_Click(object sender, EventArgs e)
        {
            
            try {
                
                switch (symbol)
                {
                    case '+':
                        wyświetlacz.Text = (a + double.Parse(wyświetlacz.Text)) + "";
                        break;

                    case '-':
                        b = a;
                        a = double.Parse(wyświetlacz.Text);
                        wyświetlacz.Text = b - double.Parse(wyświetlacz.Text) + "";
                        symbol = 'm';
                    break;

                    case 'm':
                        wyświetlacz.Text = double.Parse(wyświetlacz.Text) -a + "";
                        break;
                    case '*':
                        wyświetlacz.Text = (a * double.Parse(wyświetlacz.Text)) + "";
                        break;
                    case '/':
                        if (double.Parse(wyświetlacz.Text) == 0)
                        {
                            wyświetlacz.Text = "Nie dziel przez 0";
                        }
                        else
                        {
                            b = double.Parse(wyświetlacz.Text);
                            wyświetlacz.Text = (a/b) + "";
                            symbol = 'd';
                        }
                        break;
                    case 'd':
                        wyświetlacz.Text = double.Parse(wyświetlacz.Text) / b + "";
                        break;
                }
            }
            catch (FormatException)
            {
                wyświetlacz.Text = "0";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wyświetlacz.Text) != 0)
                    a = double.Parse(wyświetlacz.Text);
                wyświetlacz.Text = "";
                symbol = '-';
            }
            catch (FormatException)
            {
                wyświetlacz.Text = "0";
            }
        }

        private void times_Click(object sender, EventArgs e)
        {
            try { 
            if (double.Parse(wyświetlacz.Text) != 0)
                a = double.Parse(wyświetlacz.Text);
            wyświetlacz.Text = "";
            symbol = '*';
            }
            catch (FormatException)
            {
                wyświetlacz.Text = "";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wyświetlacz.Text) != 0)
                {
                    a = double.Parse(wyświetlacz.Text);
                };
                wyświetlacz.Text = "";
                symbol = '/';
            }
            catch (FormatException)
            {
                wyświetlacz.Text = "0";
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            try { 
                if (double.Parse(wyświetlacz.Text) > 0)
                {
                    wyświetlacz.Text = Math.Sqrt(double.Parse(wyświetlacz.Text)) + "";
                }
                else
                {
                    wyświetlacz.Text = "Liczba jest ujemna";
                }
            }
            catch (FormatException)
            {
                wyświetlacz.Text = "0";
            }

        }

        private void inverse_Click(object sender, EventArgs e)
        {
            try
            {
                wyświetlacz.Text = 1 / double.Parse(wyświetlacz.Text) + "";
            }
            catch (FormatException)
            {
                wyświetlacz.Text = "0";
            }
        }

        private void changesign_Click(object sender, EventArgs e)
        {
            try { 
                if(double.Parse(wyświetlacz.Text)!= 0)
            wyświetlacz.Text = -1 * double.Parse(wyświetlacz.Text) + "";
            }
            catch (FormatException)
        {
                wyświetlacz.Text = "0";
            }
        }

        
}
}