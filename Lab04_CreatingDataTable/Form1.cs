﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_CreatingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable CustomersTable = new DataTable("Customers");

        private void Form1_Load(object sender, EventArgs e)
        {
            
                TableGrid.DataSource = CustomersTable;
                CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
                CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
                CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
                CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
                CustomersTable.Columns.Add("City", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));
                CustomersTable.Columns["CustomerID"].AllowDBNull = false;
                CustomersTable.Columns["CompanyName"].AllowDBNull = false;
            //Ниже объявление Primary Key закомментировано по заданию
            /*DataColumn[] KeyColumns = new DataColumn[1];
            KeyColumns[0] = CustomersTable.Columns["CustomerID"];
            CustomersTable.PrimaryKey = KeyColumns;*/

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow CustRow = CustomersTable.NewRow();
                Object[] CustRecord =  {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                "Sales Representative", "Obere Str. 57", "Berlin", "Germany", "030-0074321"};
                CustRow.ItemArray = CustRecord;
                CustomersTable.Rows.Add(CustRow);
            }
            catch (ConstraintException err) 
            { 
                MessageBox.Show(err.Message);
            }
        }
    }
}
