using BinanceAPI._Account_._Binance_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceAPI._Account_
{
    public partial class binance_account : Form
    {
        public binance_account()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Software_Profile open = new Software_Profile
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();

            siticoneRoundedButton2.FillColor = Color.FromArgb(255, 248, 230);
            siticoneRoundedButton2.ForeColor = Color.FromArgb(240, 185, 11);

            siticoneRoundedButton3.FillColor = Color.White;
            siticoneRoundedButton3.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton1.FillColor = Color.White;
            siticoneRoundedButton1.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton4.FillColor = Color.White;
            siticoneRoundedButton4.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void binance_account_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Software_Profile open = new Software_Profile
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Binance_Restrictions open = new Binance_Restrictions
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();

            siticoneRoundedButton3.FillColor = Color.FromArgb(255, 248, 230);
            siticoneRoundedButton3.ForeColor = Color.FromArgb(240, 185, 11);

            siticoneRoundedButton1.FillColor = Color.White;
            siticoneRoundedButton1.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton2.FillColor = Color.White;
            siticoneRoundedButton2.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton4.FillColor = Color.White;
            siticoneRoundedButton4.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Binance_Terms open = new Binance_Terms
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();

            siticoneRoundedButton4.FillColor = Color.FromArgb(255, 248, 230);
            siticoneRoundedButton4.ForeColor = Color.FromArgb(240, 185, 11);

            siticoneRoundedButton3.FillColor = Color.White;
            siticoneRoundedButton3.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton2.FillColor = Color.White;
            siticoneRoundedButton2.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton1.FillColor = Color.White;
            siticoneRoundedButton1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Binance_Currency open = new Binance_Currency
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();

            siticoneRoundedButton1.FillColor = Color.FromArgb(255, 248, 230);
            siticoneRoundedButton1.ForeColor = Color.FromArgb(240, 185, 11);

            siticoneRoundedButton4.FillColor = Color.White;
            siticoneRoundedButton4.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton3.FillColor = Color.White;
            siticoneRoundedButton3.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneRoundedButton2.FillColor = Color.White;
            siticoneRoundedButton2.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
