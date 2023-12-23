﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRestaurant;
using Guna.UI2.WinForms;
using System.Data.SqlClient;
using System.IO;

namespace ITProject
{
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
        }
        Methods methods = new Methods();
        Employee_Class employee = new Employee_Class();
        private void bt_add_Click(object sender, EventArgs e)
        {
            AddNewAccount add = new AddNewAccount();
            if (add.ShowDialog() == DialogResult.OK)
                fillGrid(new SqlCommand("select * from Employee"));
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            EditAccount editAccount = new EditAccount();
            editAccount.selectededEid = list_account.CurrentRow.Cells[0].Value.ToString();
            editAccount.tb_name.Text = list_account.CurrentRow.Cells[1].Value.ToString();
            editAccount.dt_birthday.Text = list_account.CurrentRow.Cells[5].Value.ToString();
            editAccount.tb_phone.Text = list_account.CurrentRow.Cells[3].Value.ToString();
            if (list_account.CurrentRow.Cells[2].Value.ToString() == "True")
                editAccount.rb_male.Checked = true;
            else
                editAccount.rb_female.Checked = true;

            byte[] pic;

            if (list_account.CurrentRow.Cells[8].Value != null && list_account.CurrentRow.Cells[8].Value is byte[])
            {
                pic = (byte[])list_account.CurrentRow.Cells[8].Value;
                MemoryStream picture = new MemoryStream(pic);
                editAccount.pc_picture.Image = Image.FromStream(picture);
            }
            if (editAccount.ShowDialog() == DialogResult.OK)
                fillGrid(new SqlCommand("select * from Employee"));
        }

        public void fillGrid(SqlCommand cmd)
        {
            list_account.RowTemplate.Height = 50;
            list_account.DataSource = employee.getEmployee(cmd);
            list_account.Columns[0].HeaderText = "ID";
            list_account.Columns[1].HeaderText = "Name";
            list_account.Columns[2].HeaderText = "Male";
            list_account.Columns[3].HeaderText = "Phone";
            list_account.Columns[4].HeaderText = "Address";
            list_account.Columns[5].HeaderText = "Birthday";
            list_account.Columns[6].HeaderText = "Job Title";
            list_account.Columns[7].HeaderText = "Account";
            list_account.Columns[8].HeaderText = "Picture";
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)list_account.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            list_account.Columns[0].Width = 60;
            list_account.Columns[1].Width = 120;
            list_account.Columns[2].Width = 50;
            list_account.Columns[3].Width = 90;
            list_account.Columns[4].Width = 150;
            list_account.Columns[5].Width = 70;
            list_account.Columns[6].Width = 70;
            list_account.Columns[7].Width = 0;
            list_account.Columns[8].Width = 130;
            list_account.Columns[7].Visible = false;
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * from Employee"));
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * from Employee where CONCAT(EmployeeID,Name,Phone,Address,JobTitle,Account) like '%" + tb_search.Text + "%'"));
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            employee.deleteEmployee(list_account.CurrentRow.Cells[0].Value.ToString());
            employee.deleteAcc(list_account.CurrentRow.Cells[0].Value.ToString());
            fillGrid(new SqlCommand("select * from Employee"));
        }
    }
}
