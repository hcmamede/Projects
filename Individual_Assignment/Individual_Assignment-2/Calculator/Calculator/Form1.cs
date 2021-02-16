using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        string sDisp;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "0";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {

                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "+";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "1";
            if (txtDispConv.Visible == true)
            {
                if (cbx2.SelectedItem == "Miles")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) * 0.621371;

                    txtDispConv.Text = fConv.ToString();
                }

                if (cbx2.SelectedItem == "kilometres")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) / 1.60934;

                    txtDispConv.Text = fConv.ToString();
                }

                if (cbx2.SelectedItem == "Pounds")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) / 2.20462;

                    txtDispConv.Text = fConv.ToString();
                }

                if (cbx2.SelectedItem == "kilograms")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) / 0.453592;

                    txtDispConv.Text = fConv.ToString();
                }

            }

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "2";
            sConvert();

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";

                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "3";
            sConvert();
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            if (txtDisp.Text == "")
            {

                txtDisp.Text = txtDisp.Text + "0";
            }
            txtDisp.Text = txtDisp.Text + ".";
        }

        private void BtnSign_Click(object sender, EventArgs e)
        {

            //clsCalc calc = new clsCalc();
            //sDisp = txtDisp.Text;
            //string stringResult;
            //stringResult = calc.getSign(sDisp);
            //txtDisp.Text = stringResult;
            txtDisp.Text = txtDisp.Text + "(-";
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            clsCalc calc = new clsCalc();
            string sResult;
            string sHist;
            sDisp = txtDisp.Text;
            sResult = calc.getResult(sDisp);
            sHist = sDisp + "=" + sResult;
            lstHist.Items.Add(sHist);
            txtDisp.Text = sResult;
            txtDisp.ForeColor = Color.Green;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {

            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "4";
            sConvert();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "5";
            sConvert();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "6";
            sConvert();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "-";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "7";

            sConvert();

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "8";
            sConvert();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "9";

            sConvert();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {

                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "*";
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {
                //txtDisp.Text = "";
                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = "";
           
        }
        public void sConvert()
        {
            if (txtDispConv.Visible == true)
            {
                if (cbx2.SelectedItem == "Miles")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) * 0.621371;

                    txtDispConv.Text = fConv.ToString();
                }

                if (cbx2.SelectedItem == "kilometres")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) / 1.60934;

                    txtDispConv.Text = fConv.ToString();
                }

                if (cbx2.SelectedItem == "Pounds")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) / 2.20462;

                    txtDispConv.Text = fConv.ToString();
                }

                if (cbx2.SelectedItem == "kilograms")
                {
                    string cConv;
                    cConv = txtDisp.Text;
                    double fConv;
                    fConv = (double.Parse(cConv)) / 0.453592;

                    txtDispConv.Text = fConv.ToString();
                }

            }

        }
        private void BtnParent_Click(object sender, EventArgs e)
        {
            clsCalc calc = new clsCalc();
            string sBracket;
            sDisp = txtDisp.Text;
            sBracket = calc.getBracket(sDisp);
            txtDisp.Text = txtDisp.Text + sBracket;
        }

        private void BtnPerc_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {

                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "%";

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {

                txtDisp.ForeColor = Color.White;
            }
            txtDisp.Text = txtDisp.Text + "/";
        }

        private void BtnBs_Click(object sender, EventArgs e)
        {
            if (txtDisp.ForeColor == Color.Green)
            {

                txtDisp.ForeColor = Color.White;
            }
            clsCalc calc = new clsCalc();
            string sResult;
            sDisp = txtDisp.Text;
            sResult = calc.getBs(sDisp);
            txtDisp.Text = sResult;
            
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {
            //txtDisp.Text = txtDisp.Text + "";
            if (txtDispConv.Visible == false)
            {
                txtDisp.Width = (100);
                txtDispConv.Visible = true;
                cbx1.Visible = true;
                cbx2.Visible = true;
                btnChange.Visible = true;
            }
            else
            {
                txtDisp.Width = (250);
                txtDispConv.Visible = false;
                cbx1.Visible = false;
                cbx2.Visible = false;
                btnChange.Visible = false;
            }
           // txtTest.Text = result.ToString();
        }

        private void TxtDisp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
