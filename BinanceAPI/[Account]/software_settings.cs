using BinanceAPI._Account_._Binance_;
using BinanceAPI._Balances_;
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
    public partial class software_settings : Form
    {
        public software_settings()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Software_Profilec open = new Software_Profilec
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();
        }

        private void software_settings_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Software_Profilec open = new Software_Profilec
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneRoundedButton8_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Appearancec open = new Appearancec
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Pincode open = new Pincode
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(open);
            open.Show();
        }
    }
}
