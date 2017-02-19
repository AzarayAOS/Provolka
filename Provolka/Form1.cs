using System;
using System.Windows.Forms;

namespace Provolka
{
    public partial class Form1 : Form
    {
        private double p;       // это коэфициент, зависящий от материала
        private double l;       // Это длинна проводника
        private double R;       // это сопротивление материала
        private double S;       // сечение провода
        private double d;       // диаметр провода
        public int index;       // показывает, на каком объекте индех

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            p = 0.0175;
            d = 0.0000000001;
            S = 0.0000000001;
            index = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    p = 0.0175;
                    break;

                case 1:
                    p = 0.0281;
                    break;

                case 2:
                    p = 0.135;
                    break;

                case 3:
                    p = 0.176;
                    break;

                case 4:
                    p = 0.4;
                    break;

                case 5:
                    p = 0.49;
                    break;

                case 6:
                    p = 0.43;
                    break;

                case 7:
                    p = 1.1;
                    break;

                case 8:
                    p = 1.3;
                    break;
            }

            switch (index)
            {
                case 1:
                    Calcualte_R(); ShowData();
                    break;

                case 3:
                    Calcualte_l(); ShowData();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (index == 1)
            {
                if (textBox1.Text.Length != 0)
                {
                    // если вводим сопротивление
                    R = Convert.ToDouble(textBox1.Text);

                    Calcualte_R();
                    //textBox3.Text = l.ToString();
                    //textBox4.Text = S.ToString();
                    ShowData();
                }
                else
                {
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
        }

        private void Calcualte_R()
        {
            double a = 0.785 * Math.Pow(d, 2);
            S = a;

            a = a * R;
            a = a / p;
            l = a;
        }

        private void Calcualte_l()
        {
            double a = 0.785 * Math.Pow(d, 2);
            S = a;

            a = 1.27 * p * l;
            a = a / Math.Pow(d, 2);
            R = a;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
                d = Convert.ToDouble(textBox2.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (index == 3)
            {
                if (textBox3.Text.Length != 0)
                {
                    // если вводим сопротивление
                    l = Convert.ToDouble(textBox3.Text);

                    Calcualte_l();

                    //textBox1.Text = R.ToString();
                    //textBox4.Text = S.ToString();
                    ShowData();
                }
                else
                {
                    textBox1.Text = "";
                    textBox4.Text = "";
                }
            }
        }

        private void ShowData()
        {
            if (index != 1)
                textBox1.Text = R.ToString();
            textBox2.Text = d.ToString();
            if (index != 3)
                textBox3.Text = l.ToString();
            textBox4.Text = S.ToString();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            index = 2;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            index = 1;
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            index = 3;
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            index = 4;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';

            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
                    (((TextBox)sender).Text.IndexOf(",") == -1) &&
                    (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';

            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
                    (((TextBox)sender).Text.IndexOf(",") == -1) &&
                    (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';

            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
                    (((TextBox)sender).Text.IndexOf(",") == -1) &&
                    (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';

            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',') &&
                    (((TextBox)sender).Text.IndexOf(",") == -1) &&
                    (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}