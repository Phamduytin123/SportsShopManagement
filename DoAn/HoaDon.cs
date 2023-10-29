using BLL;
using DTO;
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
    public partial class HoaDon : UserControl
    {
        private DataGridViewRow row1;
        private ProductBLL a = new ProductBLL();
        private OrderDetailBLL order = new OrderDetailBLL();
        private UserBLL user = new UserBLL();
        void AddComboBoxProduct()
        {
            foreach (string temp in a.GetListProductsName())
            {
                this.cbBoxProduct.Items.Add(temp);
            }
        }
        void AddComboBoxUser()
        {
            foreach (string temp in user.GetListUserName())
            {
                this.cbBoxUsername.Items.Add(temp);
            }
        }
        
        public void getListOrderGUI()
        {
            for (int i = 0; i < order.GetAll().Count ; i++)
            {
               dataGridView1.Rows.Add(
                  order.GetAll()[i].Id, 
                  order.GetAll()[i].date,
                  user.GetbyId(order.GetAll()[i].UserID).UserName,
                  a.GetById(order.GetAll()[i].ProductID).NameProduct,
                  a.GetById(order.GetAll()[i].ProductID).Cost,
                  order.GetAll()[i].OrderQuantity,
                  a.GetById(order.GetAll()[i].ProductID).Cost * order.GetAll()[i].OrderQuantity);
            }
           
        }
        public HoaDon()
        {
            InitializeComponent();
            getListOrderGUI();
            TextReadOnlyTrue();
            HideAdd();
            HideUpdate();
            AddComboBoxProduct();
            AddComboBoxUser();
            
           


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
            txtMaHoadon.Enabled = true;
            txtMaHoadon.ReadOnly = false;
            cbBoxProduct.Enabled = true;
            //txtTenSp.ReadOnly = false;
            txtGiaSp.Enabled = false;
            //txtGiaSp.ReadOnly = false;
            cbBoxUsername.Enabled = true;
            
            txtQuantity.Enabled = true;
            txtQuantity.ReadOnly = false;
            txtDate.Enabled = true;
            txtDate.ReadOnly = false;





        }
        private void TextReadOnlyTrue()

        {
            txtMaHoadon.Enabled = false;
            txtMaHoadon.ReadOnly = true;
            cbBoxProduct.Enabled = false;
            //cbBoxProduct.ReadOnly = true;
            txtGiaSp.Enabled = false;
            //txtGiaSp.ReadOnly = false;

            cbBoxUsername.Enabled = false;
           


            txtQuantity.Enabled = false;
            txtQuantity.ReadOnly = true;
            

            txtDate.Enabled = false;
            txtDate.ReadOnly = true;


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
            txtQuantity.Clear();
            txtGiaSp.Clear();
            txtMaHoadon.Clear();
            txtDate.Clear();
            
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
            dataGridView1.Rows.Add(txtMaHoadon.Text, txtDate.Text, cbBoxUsername.SelectedItem.ToString(), cbBoxProduct.SelectedItem.ToString(), txtGiaSp.Text, txtQuantity.Text,
                Convert.ToString(Int32.Parse(txtGiaSp.Text) * Int32.Parse(txtQuantity.Text)));


            order.AddHoaDon(txtMaHoadon.Text, cbBoxUsername.SelectedItem.ToString(),
                 cbBoxProduct.SelectedItem.ToString(), Int32.Parse(txtQuantity.Text),
                 DateTime.Parse(txtDate.Text));
            TextReadOnlyTrue();
            HideAdd();
            HideUpdate();
            ShowInfo();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            row1 = dataGridView1.Rows[e.RowIndex];
            txtMaHoadon.Text = Convert.ToString(row1.Cells["ID"].Value);
            cbBoxProduct.SelectedItem = Convert.ToString(row1.Cells["ProductName"].Value);
            txtGiaSp.Text = Convert.ToString(row1.Cells["Cost"].Value);
            cbBoxUsername.SelectedItem = Convert.ToString(row1.Cells["NameCl"].Value);
            txtQuantity.Text = Convert.ToString(row1.Cells["Quantity"].Value);
            txtDate.Text = Convert.ToString(row1.Cells["Date"].Value);

        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            TextReadOnLyFalse();
            HideInfo();
            HideAdd();
            ShowUpdate();
        }

        private void bttSave_Update_Click(object sender, EventArgs e)
        {
            row1 = dataGridView1.CurrentRow;
            row1.Cells["ID"].Value = txtMaHoadon.Text;
            row1.Cells["Date"].Value = txtDate.Text;
            row1.Cells["NameCl"].Value = cbBoxUsername.SelectedItem.ToString();
            row1.Cells["Cost"].Value = txtGiaSp.Text;
            row1.Cells["ProductName"].Value = cbBoxProduct.SelectedItem.ToString();
            row1.Cells["Quantity"].Value = txtQuantity.Text;
            row1.Cells["Total"].Value = Convert.ToString(Int32.Parse(txtGiaSp.Text) * Int32.Parse(txtQuantity.Text));


            order.UpdateHoaDon(txtMaHoadon.Text, cbBoxUsername.SelectedItem.ToString(),
                 cbBoxProduct.SelectedItem.ToString(), Int32.Parse(txtQuantity.Text),
                 DateTime.Parse(txtDate.Text));


            TextReadOnlyTrue();
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

        private void bttDelete_Click(object sender, EventArgs e)
        {
            order.DeleteOrder(Int32.Parse(txtMaHoadon.Text));
            row1 = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(row1);
            
        }

        private void bttCancel_Add_Click(object sender, EventArgs e)
        {
            ClearText();
            TextReadOnlyTrue();
            HideAdd();
            ShowInfo();
        }

        private void cbBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbBoxProduct.SelectedItem != null)
            {
                this.txtGiaSp.Text = a.GetProducts(this.cbBoxProduct.SelectedItem.ToString()).Cost.ToString();
            }
        }
    }
}
