using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SurfHub
{
    public partial class login : Form
    {
        private string CurUserName;
        int tmp;
        private signup anotherformS;
        private mainform anotherformM;
        public login()
        {
            InitializeComponent();
            tmp = systemopera.initial();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //联网失败
            if (tmp == 1)
            {
                MessageBox.Show("数据连接失败，请检查网络连接！");
                return;
            }
            string this_name = this.TextboxAccout.Text;
            string this_psw = this.TextboxPassword.Text;
            try
            {
                int res = systemopera.Login(this_name, this_psw);
                //CurUserName = this_name;
                switch (res)
                {
                    case 0:
                        {
                            CurUserName = systemopera.CurUserName;
                            Thread th = new Thread(new ThreadStart(mainformstart));
                            th.Start();
                            Application.Exit();
                            break;
                        }
                    case 1:
                        {
                            MessageBox.Show("该用户不存在，请注册或检查并重试！");
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("用户名与密码不匹配， 请检查并重试！");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonlogon_Click(object sender, EventArgs e)
        {
            anotherformS = new signup();
            anotherformS.Show();
            this.Hide();
        }

        private void mainformstart()
        {
            Application.Run(new mainform(CurUserName));
        }
    }
}
