using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SurfHub
{
    public partial class mainform : Form
    {
        public string CurUserName;
        public string signsu;
        public mainform(string anotherformname)
        {
            InitializeComponent();
            CurUserName = anotherformname;
            showinfo();            
        }

        public void showinfo()
        {  
            MySqlConnection dbon = new MySqlConnection(systemopera.ConnectStr);
            try
            {
                string signstext;
                this.labelusername.Text = CurUserName;
                dbon.Open();
                string text = "select * from sign where name = '" + CurUserName + "';";
                MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["name"].ToString() == CurUserName)
                    {
                        this.labelusersign.Text = dr["signs"].ToString();
                    }
                }
                dbon.Close();
                text = "select friendsname as '好友名称' from friends where name = '" + CurUserName + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dataGridView1.DataSource = tmp;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)//简单工厂模式实现好友的增加与删除
        {
            string friendsname = this.textBox1.Text.ToString();
            systemopera oper;
            oper = friendsmangefactory.createfriendsmanage("+");
            oper.friendmanage(friendsname);
            showinfo();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string friendsname = this.textBox1.Text.ToString();
            systemopera oper;
            oper = friendsmangefactory.createfriendsmanage("-");
            oper.friendmanage(friendsname);
            showinfo();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//备忘录模式实现个性签名的撤回修改
        {
            originator curuser = new originator();
            curuser.Signs = this.labelusersign.Text.ToString();
            Caretaker c = new Caretaker();
            c.Memento = curuser.CreateMemento();
            curuser.Signs = this.textBoxupdatesign.Text.ToString();
            systemopera.signing(curuser.Signs);
            showinfo();
            curuser.SetMento(c.Memento);
            signsu = curuser.show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            systemopera.signing(signsu);
            showinfo();
        }
    }
}
