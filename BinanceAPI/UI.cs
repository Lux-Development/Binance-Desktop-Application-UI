using BinanceAPI._Account_;
using BinanceAPI._Balances_;
using BinanceAPI._Balances_._Data_.is_this_what_you_are_looking_for;
using BinanceAPI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceAPI
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        private void UI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.siticoneCustomGradientPanel1.Controls.Clear();
            _Favourited_balance open = new _Favourited_balance
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();

            timer1.Start();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


        public bool cBTC = false;
        public bool cETH = false;
        public bool cUSDT = false;
        public bool cBNB = false;
        public bool cXRP = false;
        public bool cUSDC = false;
        public bool cDOGE = false;
        public bool cADA = false;
        public bool cLTC = false;
        public bool cDOT = false;
        public bool cSHIB = false;
        public bool cDAI = false;
        public bool cBCH = false;
        public bool cXMR = false;
        public bool cSOL = false;
        public bool cBUSD = false;
        public bool cTRX = false;
        private void siticoneTextBox1_IconRightClick(object sender, EventArgs e)
        {
            string search = siticoneTextBox1.Text.ToLower();

            string[] BTC = { // Done
                "bitcoin", 
                "btc"
            };

            string[] ETH = { // Done
                "ethereum",
                "eth"
            };

            string[] USDT = { // Done
                "tether",
                "usd tether",
                "usdt"
            };

            string[] BNB = { // Done
                "binance",
                "binance coin",
                "bnb"
            };

            string[] XRP = { // Done
                "ripple",
                "xrp"
            };

            string[] USDC = { // Done
                "us coin",
                "usd coin",
                "usdc"
            };

            string[] DOGE = { // Done
                "dodgecoin",
                "dodge",
                "doge"
            };

            string[] ADA = { // Done
                "cardano",
                "ada"
            };

            string[] LTC = { // Done
                "litecoin",
                "ltc"
            };

            string[] DOT = { // Done
                "polkadot",
                "dot"
            };

            string[] SHIB = { // Done
                "shiba inu",
                "shib"
            };

            string[] DAI = { // Done
                "dai"
            };

            string[] BCH = { // Done
                "bitcoin cash",
                "bch"
            };

            string[] XMR = { // Done
                "monero",
                "xmr"
            };

            string[] SOL = { // Done
                "solana",
                "sol"
            };

            string[] BUSD = { // Done
                "binance usd",
                "busd"
            };

            string[] TRX = { // Done
                "tron",
                "trx"
            };

            foreach (string check_BTC in BTC)
            {
                if (check_BTC == search)
                {
                    cBTC = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_Bitcoin main = new Search_Bitcoin(); main.Show();
                }
                else
                {
                    cBTC = false;
                }
            }

            foreach (string check_ETH in ETH)
            {
                if (check_ETH == search)
                {
                    cETH = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_Ethereum main = new Search_Ethereum(); main.Show();
                }
                else
                {
                    cETH = false;
                }
            }

            foreach (string check_USDT in USDT)
            {
                if (check_USDT == search)
                {
                    cUSDT = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_USDT main = new Search_USDT(); main.Show();
                }
                else
                {
                    cUSDT = false;
                }
            }

            foreach (string check_BNB in BNB)
            {
                if (check_BNB == search)
                {
                    cBNB = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_BNB main = new Search_BNB(); main.Show();
                }
                else
                {
                    cBNB = false;
                }
            }

            foreach (string check_XRP in XRP)
            {
                if (check_XRP == search)
                {
                    cXRP = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_XRP main = new Search_XRP(); main.Show();
                }
                else
                {
                    cXRP = false;
                }
            }

            foreach (string check_USDC in USDC)
            {
                if (check_USDC == search)
                {
                    cUSDC = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_USDC main = new Search_USDC(); main.Show();
                }
                else
                {
                    cUSDC = false;
                }
            }

            foreach (string check_DOGE in DOGE)
            {
                if (check_DOGE == search)
                {
                    cDOGE = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_DOGE main = new Search_DOGE(); main.Show();
                }
                else
                {
                    cDOGE = false;
                }
            }

            foreach (string check_ADA in ADA)
            {
                if (check_ADA == search)
                {
                    cADA = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_ADA main = new Search_ADA(); main.Show();
                }
                else
                {
                    cADA = false;
                }
            }

            foreach (string check_LTC in LTC)
            {
                if (check_LTC == search)
                {
                    cLTC = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_LTC main = new Search_LTC(); main.Show();
                }
                else
                {
                    cLTC = false;
                }
            }

            foreach (string check_DOT in DOT)
            {
                if (check_DOT == search)
                {
                    cDOT = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_DOT main = new Search_DOT(); main.Show();
                }
                else
                {
                    cDOT = false;
                }
            }

            foreach (string check_SHIB in SHIB)
            {
                if (check_SHIB == search)
                {
                    cSHIB = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_SHIB main = new Search_SHIB(); main.Show();
                }
                else
                {
                    cSHIB = false;
                }
            }

            foreach (string check_DAI in DAI)
            {
                if (check_DAI == search)
                {
                    cDAI = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_DAI main = new Search_DAI(); main.Show();
                }
                else
                {
                    cDAI = false;
                }
            }

            foreach (string check_BCH in BCH)
            {
                if (check_BCH == search)
                {
                    cBCH = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_Bitcoincash main = new Search_Bitcoincash(); main.Show();
                }
                else
                {
                    cBCH = false;
                }
            }

            foreach (string check_XMR in XMR)
            {
                if (check_XMR == search)
                {
                    cXMR = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_XMR main = new Search_XMR(); main.Show();
                }
                else
                {
                    cXMR = false;
                }
            }

            foreach (string check_SOL in SOL)
            {
                if (check_SOL == search)
                {
                    cSOL = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_SOL main = new Search_SOL(); main.Show();
                }
                else
                {
                    cSOL = false;
                }
            }

            foreach (string check_BUSD in BUSD)
            {
                if (check_BUSD == search)
                {
                    cBUSD = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_BUSD main = new Search_BUSD(); main.Show();
                }
                else
                {
                    cBUSD = false;
                }
            }

            foreach (string check_TRX in TRX)
            {
                if (check_TRX == search)
                {
                    cTRX = true;
                    Properties.Settings.Default.searchdone = false;
                    // Open Page
                    Search_TRX main = new Search_TRX(); main.Show();
                }
                else
                {
                    cTRX = false;
                }
            }

            /*
            if (cBTC == false
                && cETH == false
                && cUSDT == false
                && cBNB == false
                && cXRP == false
                && cUSDC == false
                && cDOGE == false
                && cADA == false
                && cLTC == false
                && cDOT == false
                && cSHIB == false
                && cDAI == false
                && cBCH == false
                && cXMR == false
                && cSOL == false
                && cBUSD == false
                && cTRX == false)
            {
                _Search_NoResults main = new _Search_NoResults(); main.Show();
                Properties.Settings.Default.searchdone = false;
            }
            */
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.searchdone == false)
            {
                string pagetoshow = Properties.Settings.Default.searchreturn;

                if (pagetoshow == "BTC")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    Bitcoin_F open = new Bitcoin_F
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "ADA")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "BCH")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "BNB")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    BNB open = new BNB
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "BUSD")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "DAI")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "DODGE")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    Dodgecoin open = new Dodgecoin
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "DOT")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "ETH")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    Ethereum open = new Ethereum
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "LTC")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "SHIB")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "SOL")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "TRX")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "USDC")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    USD_Coin open = new USD_Coin
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "USDT")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    Tether open = new Tether
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "XMR")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    _Favourited_balance open = new _Favourited_balance
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }

                if (pagetoshow == "XRP")
                {
                    Properties.Settings.Default.searchdone = true;

                    this.siticoneCustomGradientPanel1.Controls.Clear();
                    Ripple open = new Ripple
                    {
                        Dock = DockStyle.Fill,
                        TopLevel = false,
                        TopMost = true
                    };
                    open.FormBorderStyle = FormBorderStyle.None;
                    this.siticoneCustomGradientPanel1.Controls.Add(open);
                    open.Show();
                }
            }
            else
            {
                
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            _Favourited_balance open = new _Favourited_balance
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Bitcoin_F open = new Bitcoin_F
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            BNB open = new BNB
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Ethereum open = new Ethereum
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Tether open = new Tether
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Ripple open = new Ripple
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            USD_Coin open = new USD_Coin
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton15_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Dodgecoin open = new Dodgecoin
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            binance_account open = new binance_account
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            software_settings open = new software_settings
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Cardano open = new Cardano
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton25_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Litecoin open = new Litecoin
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton24_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Polkadot open = new Polkadot
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton23_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            ShibaInu open = new ShibaInu
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton22_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Dai open = new Dai
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton21_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            BitcoinCash open = new BitcoinCash
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton20_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Monero open = new Monero
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton19_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Solana open = new Solana
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton18_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            BinanceUSD open = new BinanceUSD
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            this.siticoneCustomGradientPanel1.Controls.Clear();
            Tron open = new Tron
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            open.FormBorderStyle = FormBorderStyle.None;
            this.siticoneCustomGradientPanel1.Controls.Add(open);
            open.Show();
        }
    }
    
}
