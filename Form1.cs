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
        public double storage = 0.0;
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
                    HistoryListBox.Items.Add(HistoryTxtBox.Text + ResultTxtBox.Text);
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

        private void CEBtn_Click(object sender, EventArgs e)
        {
            ResultTxtBox.Clear();
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            ResultTxtBox.Clear();
            HistoryTxtBox.Clear();
            Result = 0;
        }

        private void BackspaceBtn_Click(object sender, EventArgs e)
        {
            if(ResultTxtBox.Text.Length>0)
           ResultTxtBox.Text= ResultTxtBox.Text.Remove(ResultTxtBox.Text.Length-1);
        }

        private void MSBtn_Click(object sender, EventArgs e)
        {
            if (ResultTxtBox.Text.Length > 0)
            {
                storage = Convert.ToDouble(ResultTxtBox.Text);
                Mlabel.Text = "M: " + storage.ToString();
                Mlabel.Visible = true;
                StorageListBox.Items.Add(storage);
                MCBtn.Enabled = true;
                MRBtn.Enabled = true;
            }
        }

        private void MPlusBtn_Click(object sender, EventArgs e)
        {
            if (ResultTxtBox.Text.Length > 0)
            {
                storage+=Convert.ToDouble(ResultTxtBox.Text);
                Mlabel.Text ="M: "+ storage.ToString();
                Mlabel.Visible = true;
                if (MRBtn.Enabled == false)
                    StorageListBox.Items.Add(storage);
                else
                    StorageListBox.Items[0] = storage;
                MCBtn.Enabled = true;
                MRBtn.Enabled = true;
            }
        }

        private void MRBtn_Click(object sender, EventArgs e)
        {
            if(storage!=0)
            ResultTxtBox.Text = storage.ToString();
        }

        private void MCBtn_Click(object sender, EventArgs e)
        {
            StorageListBox.Items.Clear();
            MRBtn.Enabled = false;
            MCBtn.Enabled = false;
            Mlabel.Visible = false;
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {

            if (HistoryJurnalRBtn.Visible == false)
            {
                HistoryJurnalRBtn.Visible = true;
                StorageJurnalRBtn.Visible = true;
                ClearJurnalBtn.Visible = true;
                StorageListBox.Visible = true;
            }
            else
            {
                StorageListBox.Visible = false;
                HistoryListBox.Visible = false;
                HistoryJurnalRBtn.Visible = false;
                StorageJurnalRBtn.Visible = false;
                ClearJurnalBtn.Visible = false;
            }

        }

        private void HistoryJurnalRBtn_CheckedChanged(object sender, EventArgs e)
        {
            StorageListBox.Visible = false;
            HistoryListBox.Visible = true;
            ClearJurnalBtn.Visible = true;
        }

        private void StorageJurnalRBtn_CheckedChanged(object sender, EventArgs e)
        {
            HistoryListBox.Visible = false;
            StorageListBox.Visible = true;
            ClearJurnalBtn.Visible = true;

        }

        private void ClearJurnalBtn_Click(object sender, EventArgs e)
        {
            if (StorageJurnalRBtn.Checked)
            {
                StorageListBox.Items.Clear();
                Mlabel.Text = "";
                storage = 0;
            }
            else if (HistoryJurnalRBtn.Checked)
                HistoryListBox.Items.Clear();
        }
    }
}
