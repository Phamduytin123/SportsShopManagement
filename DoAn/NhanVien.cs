using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
namespace DoAn
{
    public partial class NhanVien : UserControl
    {
        //private DAL.UserDAO user = new DAL.UserDAO();
        private UserBLL user = new UserBLL();
        private DataGridViewRow row1 = new DataGridViewRow();
        public void add()
        {
            foreach( UserAccount item in user.GetAll())
            {
                dataGridView1.Rows.Add(item.ID, item.UserName, item.UserPassword, item.UserRole);
            }
            
        }
        public NhanVien()
        {
            InitializeComponent();
            add();
            TextReadOnlyTrue();
            HideAdd();
            HideUpdate();

        }
        private void ShowInfo()
        {
            bttAdd.Show();
            bttCancel.Show();
            bttUpdate.Show();
            bttDelete.Show();
        }
        private void HideInfo()
        {
            bttAdd.Hide();
            bttCancel.Hide();
            bttUpdate.Hide();
            bttDelete.Hide();
        }
        private void HideAdd()
        {
            bttSave_Add.Hide();
            bttCancel_Add.Hide();
            bttDelete_Add.Hide();
            bttUpdate_Add.Hide();
        }
        private void ShowAdd()
        {
            bttSave_Add.Show();
            bttCancel_Add.Show();
            bttDelete_Add.Show();
            bttUpdate_Add.Show();
        }
        private void TextReadOnLyFalse()
        {
            
            txtMaNv.Enabled = true;
            txtMaNv.ReadOnly = false;
           
            txtUsername.Enabled = true;
            txtUsername.ReadOnly = false;


            txtRoleNv.Enabled = true;
            txtRoleNv.ReadOnly = false;



            txtPassword.Enabled = true;
            txtPassword.ReadOnly = false;

        }
        private void TextReadOnlyTrue()

        {
            
            txtMaNv.Enabled = false;
            txtMaNv.ReadOnly = true;
          
            txtUsername.Enabled = false;

            txtUsername.ReadOnly = true;


            txtRoleNv.Enabled = false;
            txtRoleNv.ReadOnly = true;

            txtPassword.Enabled = false;
            txtPassword.ReadOnly = true;


        }
        private void ShowUpdate()
        {
            bttAdd_Update.Show();
            bttCancel_Update.Show();
            bttSave_Update.Show();
            bttDelete_Update.Show();

        }
        private void HideUpdate()
        {
            bttAdd_Update.Hide();
            bttCancel_Update.Hide();
            bttSave_Update.Hide();
            bttDelete_Update.Hide();

        }
        private void ClearText()
        {
            txtRoleNv.Clear();
            txtPassword.Clear();
            
            txtMaNv.Clear();
            txtUsername.Clear();
        }
        private void bttAdd_Click(object sender, EventArgs e)
        {
            ClearText();
            HideInfo();
            HideUpdate();
            TextReadOnLyFalse();
            ShowAdd();

        }

        private void bttSave_Add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtMaNv.Text, txtUsername.Text, txtPassword.Text, txtRoleNv.Text);
            
            user.AddUser(new UserAccount(Int32.Parse(txtMaNv.Text), txtUsername.Text, txtPassword.Text, Byte.Parse(txtRoleNv.Text)));
            TextReadOnlyTrue();
            HideAdd();
            HideUpdate();
            ShowInfo();
        }

        private void bttCancel_Update_Click(object sender, EventArgs e)
        {
            ClearText();
            TextReadOnlyTrue();
            HideUpdate();
            ShowInfo();
        }

        private void bttCancel_Add_Click(object sender, EventArgs e)
        {
            ClearText();
            TextReadOnlyTrue();
            HideAdd();
            ShowInfo();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            TextReadOnLyFalse();
            HideInfo();
            HideAdd();
            ShowUpdate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row1 = dataGridView1.Rows[e.RowIndex];
            txtMaNv.Text = Convert.ToString(row1.Cells["ID"].Value);
            txtRoleNv.Text = Convert.ToString(row1.Cells["Role"].Value);
            txtUsername.Text = Convert.ToString(row1.Cells["Username"].Value);
            txtPassword.Text = Convert.ToString(row1.Cells["Password"].Value);
        }

        private void bttSave_Update_Click(object sender, EventArgs e)
        {
            row1 = dataGridView1.CurrentRow;
            row1.Cells["ID"].Value = txtMaNv.Text;
            
            row1.Cells["Role"].Value = txtRoleNv.Text;
            
            row1.Cells["Username"].Value = txtUsername.Text;
            row1.Cells["Password"].Value = txtPassword.Text;
            user.UpdateUser(new UserAccount(Int32.Parse(txtMaNv.Text), txtUsername.Text, txtPassword.Text, Byte.Parse(txtRoleNv.Text)));

            TextReadOnlyTrue();
            HideUpdate();
            ShowInfo();
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            user.DeleteUser(Int32.Parse(txtMaNv.Text));
            row1 = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(row1);
        }

        
    }
}
