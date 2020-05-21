using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_19_05_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Result=0.0;
        public char[] SumbolArr = { '+', '-', '*', '/' };
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if(!(HistoryTxtBox.Text.LastOrDefault()==')'))
            ResultTxtBox.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                ResultTxtBox.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {

            if (HistoryTxtBox.Text.Contains('='))
            {
                HistoryTxtBox.Clear();
                ResultTxtBox.Clear();
            }
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
                if ((!ResultTxtBox.Text.All(p => p == '0')) || (ResultTxtBox.Text.Length==0)) 
            ResultTxtBox.Text += "0";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (!(HistoryTxtBox.Text.LastOrDefault() == ')'))
            {
                if (ResultTxtBox.Text.Length == 0)
                    ResultTxtBox.Text = "0";
                if (!ResultTxtBox.Text.Contains(','))
                    ResultTxtBox.Text += ",";
            }
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (ResultTxtBox.Text.Length > 0 && HistoryTxtBox.Text.LastOrDefault() != ')')
                {
                    if (HistoryTxtBox.Text.LastOrDefault() == '=') HistoryTxtBox.Clear();
                    HistoryTxtBox.Text += $"negate({ResultTxtBox.Text})";
                    ResultTxtBox.Text = (Convert.ToDouble(ResultTxtBox.Text) * (-1)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
           
        }
        public bool FindResult()
        {
            try
            {
                if (HistoryTxtBox.Text.Contains('=')) HistoryTxtBox.Clear();
                char sumbol = HistoryTxtBox.Text.Intersect(SumbolArr).LastOrDefault();
                if (HistoryTxtBox.Text.Length == 0 || sumbol == '\0') Result = Convert.ToDouble(ResultTxtBox.Text);
                if (ResultTxtBox.Text.Length > 0)
                {
                    if (sumbol == '+') Result += Convert.ToDouble(ResultTxtBox.Text);
                    if (sumbol == '-') Result -= Convert.ToDouble(ResultTxtBox.Text);
                    if (sumbol == '*')
                    {
                        if (Result == 0) Result = 1;
                        Result *= Convert.ToDouble(ResultTxtBox.Text);
                    }
                    if (sumbol == '/')
                    {
                        if (Convert.ToDouble(ResultTxtBox.Text) == 0)
                            throw new Exception("Ошибка: Деления на нол!!!");
                        Result /= Convert.ToDouble(ResultTxtBox.Text);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
            return false;
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                    if (FindResult())
                    {
                    if (HistoryTxtBox.Text.LastOrDefault() == ')')
                        HistoryTxtBox.Text += "+";
                    else
                        HistoryTxtBox.Text += ResultTxtBox.Text + "+";
                    ResultTxtBox.Clear();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void OunDevResultBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ResultTxtBox.Text.Length > 0 && HistoryTxtBox.Text.LastOrDefault() != ')')
                {
                    if (HistoryTxtBox.Text.LastOrDefault() == '=') HistoryTxtBox.Clear();
                    HistoryTxtBox.Text += $"1/({ResultTxtBox.Text})";
                    ResultTxtBox.Text = (1 / Convert.ToDouble(ResultTxtBox.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FindResult())
                {
                    if (HistoryTxtBox.Text.LastOrDefault() == ')')
                        HistoryTxtBox.Text += "-";
                    else
                        HistoryTxtBox.Text += ResultTxtBox.Text + "-";
                    ResultTxtBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void MultipleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FindResult())
                {
                    if (HistoryTxtBox.Text.LastOrDefault() == ')')
                        HistoryTxtBox.Text += "*";
                    else
                        HistoryTxtBox.Text += ResultTxtBox.Text + "*";
                    ResultTxtBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void DevideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FindResult())
                {
                    if(HistoryTxtBox.Text.LastOrDefault() == ')')
                        HistoryTxtBox.Text +="/";
                    else
                    HistoryTxtBox.Text += ResultTxtBox.Text + "/";
                    ResultTxtBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FindResult())
                {
                    if(HistoryTxtBox.Text.LastOrDefault()==')')
                        HistoryTxtBox.Text +=  "=";
                    else
                    HistoryTxtBox.Text += ResultTxtBox.Text + "=";
                    ResultTxtBox.Text= Result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void KvadratBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ResultTxtBox.Text.Length > 0 && HistoryTxtBox.Text.LastOrDefault() != ')')
                {
                    if (HistoryTxtBox.Text.LastOrDefault() == '=') HistoryTxtBox.Clear();
                    HistoryTxtBox.Text += $"Pow({ResultTxtBox.Text})";
                    ResultTxtBox.Text = (Math.Pow(Convert.ToDouble(ResultTxtBox.Text), 2)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void SqrtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ResultTxtBox.Text.Length > 0 && HistoryTxtBox.Text.LastOrDefault() != ')')
                {
                    if (HistoryTxtBox.Text.LastOrDefault() == '=') HistoryTxtBox.Clear();
                    HistoryTxtBox.Text += $"sqrt({ResultTxtBox.Text})";
                    ResultTxtBox.Text = (Math.Sqrt(Convert.ToDouble(ResultTxtBox.Text))).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }

        private void ProtsentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ResultTxtBox.Text.Length > 0 && HistoryTxtBox.Text.LastOrDefault() != ')')
                {
                    if (HistoryTxtBox.Text.LastOrDefault() == '=') HistoryTxtBox.Clear();
                    HistoryTxtBox.Text += $"({ResultTxtBox.Text}%)";
                    ResultTxtBox.Text = (Result*Convert.ToDouble(ResultTxtBox.Text)/100).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResultTxtBox.Clear();
            }
        }
    }
}
