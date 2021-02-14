using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using BiliApi.Auth;
using BiliApi.Exceptions;

namespace FastBan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() =>
            {
                var login = new QRLogin();
                Program.biliauth = login;
                while (true)
                {
                    try
                    {
                        getQRCode();
                        login.Login();
                        break;
                    }
                    catch (AuthenticateFailedException ex)
                    {
                        login.RefreshQRCode();
                    }
                }
                Hide();
                new ManagementWindow().ShowDialog();
                Application.Exit();
            })).Start();
        }

        private void getQRCode()
        {
            string url = "https://api.pwmqr.com/qrcode/create/?url=" + Program.biliauth.QRToken.ScanUrl;
            qrcode.LoadAsync(url);
        }

        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }
            return (sb.ToString());
        }
    }
}
