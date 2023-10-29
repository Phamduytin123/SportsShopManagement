using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class DangNhap : Form
    {
        UserBLL userBLL = new UserBLL();
        public Boolean isLogin;
        public static String username;
        public DangNhap()
        {
            InitializeComponent();
            this.label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (userBLL.CheckUser(textBox1.Text, textBox2.Text))
            {
                isLogin = true;
                username = textBox1.Text;
                this.Close();
            }
            else
            {
                isLogin = false;
                this.label3.Text = "Sai Thong Tin Dang Nhap!!";
            }
            
            
        }

       
    }
}
