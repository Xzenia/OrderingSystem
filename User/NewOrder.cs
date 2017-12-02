﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseController;

namespace User
{
    public partial class NewOrder : Form
    {
        //ADD DATE AND TIME OF TRANSACTION!!!
        BindingSource bs = new BindingSource();
        ProductDatabaseController pdc = new ProductDatabaseController();
        OrderDatabaseController odc = new OrderDatabaseController();
        DataTable orders = new DataTable();
        LoginCookie cookie = new LoginCookie();
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            loadDatabase();
            setupOrderDataGridView();
        }

        private void loadDatabase()
        {
            bs.DataSource = pdc.viewAllData("SP_NEWORDERVIEW").Tables[0];
            productListGridView.DataSource = bs;

        }

        private void productListGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.productListGridView.Rows[e.RowIndex];
                    String productName = row.Cells[1].Value.ToString();
                    double productPrice = Convert.ToDouble(row.Cells[2].Value.ToString());
                    orders.Rows.Add(productName, productPrice);

                }
            }
            catch (Exception NullRowException)
            {
                MessageBox.Show("Error! Row is null! "+NullRowException.Message);
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string sBtn = btn.Name;

            switch (sBtn)
            {
                case "btnAccept":
                    acceptOrder();
                    break;
                case "btnCancel":
                    cancelOrder();
                    break;
                
                default:
                    MessageBox.Show("Something went wrong!");
                    break;
            }
        }

        private void setupOrderDataGridView()
        {
            orders.Columns.Add(new DataColumn("Product Name"));
            orders.Columns.Add(new DataColumn("Product Cost"));
            orderDataGridView.DataSource = orders;
        }

        private void acceptOrder()
        {
            prepareFinalDataTable();
        }


        private void prepareFinalDataTable()
        {
            //Creating the final DataTable to be sent to the server.
            DataTable final = new DataTable();
            final.Columns.Add("OrderId", typeof(int));
            final.Columns.Add("CustomerId", typeof(int));
            final.Columns.Add("CustomerName", typeof(string));
            final.Columns.Add("CustomerType", typeof(string));
            final.Columns.Add("ItemOrdered", typeof(string));
            final.Columns.Add("ItemPrice", typeof(double));
            final.Columns.Add("TotalCost", typeof(double));
            
            Random rnd = new Random();
            double totalCost = 0;
            cookie.readFile();
            for (int count = 0; count < orders.Rows.Count; count++)
            {
                double tempPrice = Convert.ToDouble(orders.Rows[count].ItemArray[1]);
                totalCost = totalCost + tempPrice;
            }
            for (int count = 0; count < orders.Rows.Count; count++)
            {
                int customerId = cookie.UserId;
                String customerName = cookie.CustomerName;
                String customerType = cookie.CustomerType;
                int orderId = rnd.Next(111111, 999999);
                string productName = Convert.ToString(orders.Rows[count].ItemArray[0]);
                double productCost = Convert.ToDouble(orders.Rows[count].ItemArray[1]);
                
                final.Rows.Add(orderId, customerId, customerName, customerType, productName, productCost, totalCost);
            }
            try
            {
                Boolean confirm = odc.addOrderInfo(final);
                if (confirm)
                {
                    MessageBox.Show("Order sent!");
                }
                else
                {
                    MessageBox.Show("Order failed!");
                }
            }
            catch (Exception addOrderFailedException)
            {
                MessageBox.Show(addOrderFailedException.Message);
            }
        }


        private void cancelOrder()
        {
            orders.Rows.Clear();
        }


    }
}