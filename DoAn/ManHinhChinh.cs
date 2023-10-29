using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class ManHinhChinh : Form
    {

        public ManHinhChinh()
        {
            
            InitializeComponent();
            
            if (!DangNhap.username.EndsWith("admin01") && !DangNhap.username.EndsWith("admin02"))
            {
                
                bttNhanVien.Enabled = false;
                bttNhanVien.BackColor = Color.Silver;
            }
            lbHello.Text = "Hello " + DangNhap.username;
            //this.SetBounds(100, 100, 982, 660);
            sanPham1.Hide();
            nhanVien1.Hide();
            hoaDon1.Hide();
        }

        private void bttTrangChu_Click(object sender, EventArgs e)
        {
            trangChu1.Show();
            sanPham1.Hide();
            nhanVien1.Hide();
            hoaDon1.Hide();
        }

        private void bttSanPham_Click(object sender, EventArgs e)
        {
            trangChu1.Hide();
            sanPham1.Show();
            nhanVien1.Hide();
            hoaDon1.Hide();
        }

        private void bttNhanVien_Click(object sender, EventArgs e)
        {
            
            trangChu1.Hide();
            sanPham1.Hide();
            nhanVien1.Show();
            hoaDon1.Hide();
        }

        

        private void bttHoaDon_Click(object sender, EventArgs e)
        {
            trangChu1.Hide();
            sanPham1.Hide();
            nhanVien1.Hide();
            hoaDon1.Show();
        }

        private void bttDangXuat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
