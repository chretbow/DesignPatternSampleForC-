using StrategyPattern.CashStrategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        private double total = 0.0d;

        public Form1()
        {
            InitializeComponent();
            lblResult.Text= total.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 純策略模式
            //CashContext cc = null;

            //switch (cbxType.SelectedItem.ToString())
            //{
            //    case "正常收費":
            //        cc = new CashContext(new CashNormal());
            //        break;
            //    case "滿300返100":
            //        cc = new CashContext(new CashReturn("300", "100"));
            //        break;
            //    case "打8折":
            //        cc = new CashContext(new CashRebate("0.8"));
            //        break;
            //    default:
            //        break;
            //}

            // 策略 + 簡單工廠模式
            CashContextFactory cc = new CashContextFactory(cbxType.SelectedItem.ToString());
            double totalPrices = cc.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtCount.Text));
            total = total + totalPrices;
            txtList.AppendText("單價: " + txtPrice.Text + " 數量: " + txtCount.Text + " " + cbxType.SelectedItem + " 合計: " + totalPrices.ToString() + "\r\n");
            lblResult.Text = total.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            total = 0.0d;
            txtList.Clear();
            lblResult.Text = total.ToString();
        }
    }
}
