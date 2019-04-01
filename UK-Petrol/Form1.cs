using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UK_Petrol
{
    public partial class mainForm : Form
    {
        public string[,] petrols = new string[,]
        {
            {"Petrol", "2" },
            {"Diesel", "1" },
            {"LPG", "3" },
            {"Petrol Leaded", "1.5" }
        };
        //Get the customers from customers file and make a new one of it to use in the app
        private Customers Customer = new Customers();
        public static string customerNameClicked = "";
        public static bool isCustomer = true;
        public static bool showCustomerDataPage = true;
        public mainForm()
        {
            InitializeComponent();
        }
        //Home button handler
        private void BackToHomeBttn_Click(object sender, EventArgs e)
        {
            //Hide all panels
            customerpanel.Visible = false;
            customersPanel.Visible = false;
            Customersbutton2.Visible = false;
            customerDitailspanel1.Visible = false;
            dataGridView1.Rows.Clear(); // Clear customers Grid not to have duplicated customer
        }
        //Search button handler which make customer page visible
        private void searchBttn_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < Customer.CustomerData.GetLongLength(0); rows++)//Looping through rows of 2d array
            {
                for (int cols = 0; cols < Customer.CustomerData.GetLongLength(1); cols++)//Looping through clos of each rows of 2d array
                {
                    if (customerNameClicked == Customer.CustomerData[rows, 0])
                    {
                        customerDitailspanel1.Visible = true; //show customer panel
                        return;
                    }
                    else
                    {
                        notFoundLab.Text = "Customer does not exist";
                    }
                }
            }
        }
        //This function shows list of customers in search page by:
        //Create new format of customers and set them to Grid 
        private void setCustomersListGrid()
        {
            dataGridView1.Rows.Clear();// This line clear the Grid 
            for (int row = 0; row < Customer.CustomerData.GetLongLength(0); row++)
            {
                string[] newCustomer = new string[Customer.CustomerData.GetLongLength(1)];//Creat a new row for Grid

                for (int cols = 0; cols < Customer.CustomerData.GetLongLength(1); cols++)
                {
                    newCustomer[cols] = Customer.CustomerData[row, cols];//Assign new created row with customer data
                }
                dataGridView1.Rows.Add(newCustomer); //add new created row to Grid 
            }
        }
        //Customers button in home page
        private void goToCustomersPageBttn_Click(object sender, EventArgs e)
        {
            customersPanel.Visible = true;
            setCustomersListGrid();
        }
        //Search text box on change handler
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customerNameClicked = textBox1.Text;
            notFoundLab.Text = "";
        }
        //Grid click handler on customers list to show a customer ditails   
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && Customer.CustomerData.GetLength(0) > e.RowIndex)// check if the right customer has been clicked
            {
                customerNameClicked = Customer.CustomerData[e.RowIndex, 0];
                textBox1.Text = Customer.CustomerData[e.RowIndex, 0];
                customerDitailspanel1.Visible = true; //show customer panel
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
        }
        //Set input texts in edit customer pag with customer data
        private void setDataToEditCustomerPag()
        {
            for (int rows = 0; rows < Customer.CustomerData.GetLongLength(0); rows++)
            {
                for (int cols = 0; cols < Customer.CustomerData.GetLongLength(1); cols++)
                {
                    if (customerNameClicked == Customer.CustomerData[rows, 0])
                    {
                        nameTxt.Text = Customer.CustomerData[rows, 0];
                        numberTxt.Text = Customer.CustomerData[rows, 1];
                        emailTxt.Text = Customer.CustomerData[rows, 2];
                        PetrolTypeTxt.Text = Customer.CustomerData[rows, 3];
                        amountOfLitrTxt.Text = (Customer.CustomerData[rows, 4]);
                        priceOfLitrTxt.Text = (Customer.CustomerData[rows, 5]);
                        totalPriceTxt.Text = ((int.Parse(Customer.CustomerData[rows, 5]) * int.Parse(Customer.CustomerData[rows, 4])).ToString());//calculat the total price
                        notFoundLab.Text = "";
                        isCustomer = false;
                        return;
                    }
                }
            }
        }
        //show single customer on customer page
        private void customerpanel_Paint(object sender, PaintEventArgs e)
        {
            if (isCustomer)
            {
                setDataToEditCustomerPag();
            }
            Customersbutton2.Visible = true;
        }
        private void customersPanel_Paint(object sender, PaintEventArgs e)
        {
        }
        // go to the customers page button handler
        private void Customersbutton2_Click(object sender, EventArgs e)
        {
            Customersbutton2.Visible = false;
            customerpanel.Visible = false;
            button2.Visible = false;
            label10.Visible = false;
            customerDitailspanel1.Visible = false;
            isCustomer = true;
            notFoundLab.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        //Edit customer Button handler
        private void button2_Click(object sender, EventArgs e)
        {
            saveAndUpdateCustomer();
        }
        private void saveAndUpdateCustomer()
        {
            //valedation 
            if (nameTxt.Text == "")
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }
            if (numberTxt.Text == "")
            {
                MessageBox.Show("Number cannot be empty.");
                return;
            }
            if (emailTxt.Text == "")
            {
                MessageBox.Show("Email cannot be empty.");
                return;
            }
            if (PetrolTypeTxt.Text == "")
            {
                MessageBox.Show("Petrol Type cannot be empty.");
                return;
            }
            if (amountOfLitrTxt.Text == "")
            {
                MessageBox.Show("Amount Of Litr Type cannot be empty.");
                return;
            }
            //Find and update the customer
            for (int rows = 0; rows < Customer.CustomerData.GetLongLength(0); rows++)
            {
                for (int cols = 0; cols < Customer.CustomerData.GetLongLength(1); cols++)
                {
                    if (customerNameClicked == Customer.CustomerData[rows, 0])
                    {
                        if (showCustomerDataPage)
                        {
                            Customer.CustomerData[rows, 0] = nameTxt.Text; //Assign the founded customer data with text input
                            Customer.CustomerData[rows, 1] = numberTxt.Text;
                            Customer.CustomerData[rows, 2] = emailTxt.Text;
                            Customer.CustomerData[rows, 3] = PetrolTypeTxt.Text;
                            Customer.CustomerData[rows, 4] = amountOfLitrTxt.Text;
                            Customer.CustomerData[rows, 5] = priceOfLitrTxt.Text;
                            MessageBox.Show("Customer updated successfully."); //Alert a message to show Customer updated succesfuly. and ok button
                            customerNameClicked = nameTxt.Text;
                            setCustomersListGrid();
                            isCustomer = true;
                            customerpanel.Visible = false;
                            button2.Visible = false;
                            label10.Visible = false;
                            showCustomerData();
                            customerDitailspanel1.Update();
                            customerDitailspanel1.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Customer saved successfully.");
                        }
                        return; //To stop further actions
                    }
                }
            }
        }
        private void Insert_Click(object sender, EventArgs e)
        {
        }
        //Loop through customers and find a customer for customer page
        private void showCustomerData()
        {
            if (showCustomerDataPage)
            {
                for (int rows = 0; rows < Customer.CustomerData.GetLongLength(0); rows++)
                {
                    for (int cols = 0; cols < Customer.CustomerData.GetLongLength(1); cols++)
                    {
                        if (customerNameClicked == Customer.CustomerData[rows, 0]) //check and find the customer we look for
                        {
                            fullNameLab.Text = Customer.CustomerData[rows, 0]; //Assign the label to the founded customer data
                            PhoneLab.Text = Customer.CustomerData[rows, 1];
                            emailLab.Text = Customer.CustomerData[rows, 2];
                            petrolLab.Text = Customer.CustomerData[rows, 3];
                            literLab.Text = "L" + (Customer.CustomerData[rows, 4]);
                            literPriceLab.Text = "£" + (Customer.CustomerData[rows, 5]);
                            totalLab.Text = "£" + ((int.Parse(Customer.CustomerData[rows, 5]) * int.Parse(Customer.CustomerData[rows, 4])).ToString());
                            notFoundLab.Text = "";
                            return;
                        }
                    }
                }
            }
        }

        // show the customer distal
        private void customerDitailspanel1_Paint(object sender, PaintEventArgs e)
        {
            showCustomerData(); //Calling showCustomerData function
            Customersbutton2.Visible = true; //Make the customers button visible
        }

        //go to edit customer page
        private void button1_Click_1(object sender, EventArgs e)
        {
            showCustomerDataPage = true;
            customerpanel.Visible = true;
            customerDitailspanel1.Visible = false;
            button2.Visible = true;
            label10.Visible = true;
            saveCustomerBtn.Visible = false;
        }
        private void label20_Click(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void totalCalculator()
        {
            if (amountOfLitrTxt.Text == "")
            {
                totalPriceTxt.Text = "";
                return;
            }
            else
            {
                for (int rows = 0; rows < petrols.GetLongLength(0); rows++)
                {
                    for (int cols = 0; cols < petrols.GetLongLength(1); cols++)
                    {
                        if (PetrolTypeTxt.Text == petrols[rows, 0])
                        {
                            priceOfLitrTxt.Text = petrols[rows, 1];
                            totalPriceTxt.Text = (double.Parse(amountOfLitrTxt.Text) * double.Parse(petrols[rows, 1])).ToString();
                            return;
                        }
                    }
                }
            }
        }
        private void PetrolTypeTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalCalculator();
        }

        private void amountOfLitrTxt_TextChanged(object sender, EventArgs e)
        {

            totalCalculator();
        }

        private void amountOfLitrTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (!char.IsLetter(e.KeyChar) && char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar) && char.IsNumber(e.KeyChar))
            if (char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Insert_Click_1(object sender, EventArgs e)
        {
            customerpanel.Visible = true;
            saveCustomerBtn.Visible = true;
            addNewCustomerLab.Visible = true;
            showCustomerDataPage = false;
            customerDitailspanel1.Visible = false;
            button2.Visible = false;
            label10.Visible = false;
            nameTxt.Text = "";
            numberTxt.Text = "";
            emailTxt.Text = "";
            PetrolTypeTxt.Text = "";
            amountOfLitrTxt.Text = "";
            priceOfLitrTxt.Text = "";
            totalPriceTxt.Text = "";
            notFoundLab.Text = "";
        }
        private void saveCustomerBtn_Click(object sender, EventArgs e)
        {
            saveAndUpdateCustomer();
        }
    }
}
