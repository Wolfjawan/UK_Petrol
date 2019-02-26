using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UK_Petrol
{
    public partial class mainForm : Form
    {
        private Customers Customer = new Customers();
        public static string customerNameClicked = "";
        public mainForm()
        {
            InitializeComponent();
        }

        private void BackToHomeBttn_Click(object sender, EventArgs e)
        {
            customerpanel.Visible = false;
            customersPanel.Visible = false;
            Customersbutton2.Visible = false;
            dataGridView1.Rows.Clear();
        }

        private void searchBttn_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < 3; rows++)
            {
                for (int cols = 0; cols < 5; cols++)
                {
                    if (customerNameClicked == Customer.CustomerData[rows, 0])
                    {
                      customerpanel.Visible = true;
                    }
                    else
                    {
                        notFoundLab.Text = "Customer does not exist";
                    }
                }
            }
        }

        private void goToCustomersPageBttn_Click(object sender, EventArgs e)
        {
            customersPanel.Visible = true;
            for (int row = 0; row < Customer.CustomerData.GetLongLength(0); row++)
            {
                string[] newCustomer = new string[Customer.CustomerData.GetLongLength(1)];

                for (int cols = 0; cols < Customer.CustomerData.GetLongLength(1); cols++)
                {
                    newCustomer[cols] = Customer.CustomerData[row, cols];
                }
                dataGridView1.Rows.Add(newCustomer);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            
            customerNameClicked = textBox1.Text;
            notFoundLab.Text = "";
            for (int i = 0; i < Customer.CustomerData.GetLength(0); i++)
            {
                for (int j = 0; j < Customer.CustomerData.GetLength(1); j++)
                {
                    if (textBox1.Text.Equals(Customer.CustomerData[i, j]))
                    {
                        dataGridView2.Rows.Add(Customer.CustomerData[i,j]);
                        dataGridView2.Visible = true;
                    }
                }
            }
            if (textBox1.Text=="")
            {
                dataGridView2.Visible = false;
            }

    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Customer.CustomerData.GetLength(0) > e.RowIndex)
            {
                customerNameClicked = Customer.CustomerData[e.RowIndex, 0];
                textBox1.Text = Customer.CustomerData[e.RowIndex, 0];
                customerpanel.Visible = true;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void customerpanel_Paint(object sender, PaintEventArgs e)
        {
            for (int rows = 0; rows < 3; rows++)
            {
                for (int cols = 0; cols < 4; cols++)
                {
                    if (customerNameClicked == Customer.CustomerData[rows, 0])
                    {
                        nameTxt.Text = Customer.CustomerData[rows, 0];
                        numberTxt.Text = Customer.CustomerData[rows, 1];
                        emailTxt.Text = Customer.CustomerData[rows, 2];
                        PetrolTypeTxt.Text = Customer.CustomerData[rows, 3];
                        amountOfLitrTxt.Text = Customer.CustomerData[rows, 4];
                        priceOfLitrTxt.Text = Customer.CustomerData[rows, 5];
                        totalPriceTxt.Text = (int.Parse(Customer.CustomerData[rows, 5]) * int.Parse(Customer.CustomerData[rows, 4])).ToString();
                        notFoundLab.Text = "";
                    }
                }
            }
            Customersbutton2.Visible = true;
        }

        private void customersPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customersbutton2_Click(object sender, EventArgs e)
        {
            Customersbutton2.Visible = false;
            customerpanel.Visible = false;
            dataGridView2.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Customer.CustomerData.GetLength(0) > e.RowIndex)
            {
                customerNameClicked = Customer.CustomerData[e.RowIndex, 0];
                textBox1.Text = Customer.CustomerData[e.RowIndex, 0];
                customerpanel.Visible = true;
            }
        }
    }
}
