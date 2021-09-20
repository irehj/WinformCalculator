using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCalculator
{
    public partial class MainForm : Form
        
    {
        private string formula;
        public MainForm()
        {
            InitializeComponent();

            InitEvent();
        }
        private void InitEvent()
        {
            btnZero.Click += BtnCommon_Click;
            btnOne.Click += BtnCommon_Click;
            btnTwo.Click += BtnCommon_Click;
            btnThree.Click += BtnCommon_Click;
            btnFour.Click += BtnCommon_Click;
            btnFive.Click += BtnCommon_Click;
            btnSix.Click += BtnCommon_Click;
            btnSeven.Click += BtnCommon_Click;
            btnEight.Click += BtnCommon_Click;
            btnNine.Click += BtnCommon_Click;
            btnMultiply.Click += BtnCommon_Click;
            btnDivision.Click += BtnCommon_Click;
            btnPlus.Click += BtnCommon_Click;
            btnMinus.Click += BtnCommon_Click;
            btnRemain.Click += BtnCommon_Click;
            btnPoint.Click += BtnCommon_Click;
            // 텍스트 박스 초기화
            btnCancel.Click += BtnCancel_Click;
            // 수식 계산 
            btnResult.Click += BtnResult_Click;
        }



        //sender 버튼 자체, EVENT 
        private void BtnCommon_Click(object sender, EventArgs e)
        {
            formula += ((Button)sender).Text;
            tbResult.Text = formula;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            formula = "";
            tbResult.Text = formula;
        }




        private void BtnResult_Click(object sender, EventArgs e)
        {
            string result = tbResult.Text;
            if (result.Contains("+"))
            {
                tbResult.Text = Plus(result.Split('+')[0], result.Split('+')[1]).ToString();
            }
            if (result.Contains("-"))
            {
                tbResult.Text = Minus(result.Split('-')[0], result.Split('-')[1]).ToString();
            }
            if (result.Contains("x"))
            {
                tbResult.Text = Mutiply(result.Split('x')[0], result.Split('x')[1]).ToString();
            }
            if (result.Contains("÷"))
            {
                tbResult.Text = Division(result.Split('÷')[0], result.Split('÷')[1]).ToString();
            }

        }

        private decimal Plus(string first, string second)
        {
            return decimal.Parse(first) + decimal.Parse(second);
        }
        private decimal Minus(string first, string second)
        {
            return decimal.Parse(first) - decimal.Parse(second);
        }
        private decimal Mutiply(string first, string second)
        {
            return decimal.Parse(first) * decimal.Parse(second);
        }
        private decimal Division(string first, string second)
        {
            return decimal.Parse(first) / decimal.Parse(second);
        }
        //공부하기 부동소수점 
        //decimal vs float 차이점 공부 
    }
}


  
