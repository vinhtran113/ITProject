﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        public static DataTable food_Order;
        public static DataTable drink_Order;
        public static DataTable order;
        public static string static_orderID;

        private void bt_selectDishes_Click(object sender, EventArgs e)
        {
            SelectDishes selectDishes = new SelectDishes();
            if (selectDishes.ShowDialog() == DialogResult.OK)
            {
                order = food_Order;
                order.Merge(drink_Order);
                for (int i = 0; i < order.Rows.Count; i++)
                {
                    if (order.Rows[i][2].ToString() == "")
                    {
                        order.Rows[i].Delete();
                    }
                }
                order.AcceptChanges();

                list_dishes.DataSource = order;
                list_dishes.Columns[0].Visible = false;
                list_dishes.Columns[1].HeaderText = "Dish";
                list_dishes.Columns[2].HeaderText = "Quantity";
                list_dishes.Columns[1].Width = 180;
                //bt_selectDishes.Enabled = false;
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DB_Class db = new DB_Class();
        Exception_Class ex = new Exception_Class();
        private void bt_order_Click(object sender, EventArgs e)
        {
            if (ex.BlankBox(this) && order!=null)
            {
                if (int.Parse(tb_amountOfDiner.Text)<=0 || int.Parse(tb_amountOfDiner.Text)>6)
                {
                    MessageBox.Show("Invalid amount of diner!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                SqlCommand cmd = new SqlCommand("SELECT [dbo].[AUTO_IDOrder]()", db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                string orderID = table.Rows[0][0].ToString();
                foreach (DataRow row in order.Rows)
                {
                    cmd = new SqlCommand("INSERT [Order] VALUES (@id, @dish, @quantity)", db.getConnection);
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = orderID;
                    cmd.Parameters.Add("@dish", System.Data.SqlDbType.NVarChar).Value = row[0].ToString();
                    cmd.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = row[2].ToString();
                    db.openConnection();
                    cmd.ExecuteNonQuery();
                    db.closeConnection();
                }
                WorkStation.guest = int.Parse(tb_amountOfDiner.Text);
                static_orderID = orderID;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fill all textbox please!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
