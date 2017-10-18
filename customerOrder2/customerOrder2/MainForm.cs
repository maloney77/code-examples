/*Name: Kyle Maloney
 * Course: IST 1552
 * Date: 4/20/2017
 * Assignment 4*/

 //Check blank boxes when form loads and add button is clicked
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
using System.Text.RegularExpressions;

namespace customerOrder2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //establishing connection and current string variables
        OleDbConnection connectionObject = new OleDbConnection();
        string currentCustomer = "";
        string currentZipCode = "";


        //Opens database with connection string
        public void openDatabase()
        {
            try
            {
                string conn = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=customerOrdersMore.accdb;" +
                    "Persist Security Info = False;";
                connectionObject.ConnectionString = conn;
                connectionObject.Open();

            }
            catch (Exception errmsg)
            {
                MessageBox.Show("Database could not open because: " + errmsg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Fills customer combo box
        private void fillCustComboBox()
        {
            try
            {
                custNumsDS.Clear();

                custCMB.DisplayMember = "";
                custCMB.ValueMember = "";

                string sql = "SELECT distinct customer_id from customers order by customer_id";
                OleDbDataAdapter daCustNums = new OleDbDataAdapter(sql, connectionObject);

                daCustNums.Fill(custNumsDS, "customers");

                custCMB.DataSource = custNumsDS.Tables[0];
                custCMB.DisplayMember = "customer_id";
                custCMB.ValueMember = "customer_id";
                //custCMB.DataBindings.Add("SelectedValue", custNumsDS.Tables[0], "customer_id");
            }
            catch (Exception errmsg)
            {
                MessageBox.Show("Trouble pulling customer ids from database because: " + errmsg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Fills zip code combo box
        private void fillZipComboBox()
        {
            try
            {
                string sql = "SELECT zip_code from customers order by customer_id";
                        
                OleDbDataAdapter daZipNums = new OleDbDataAdapter(sql, connectionObject);
                daZipNums.Fill(zipDS, "customers");
                zipCMB.DataSource = zipDS.Tables[0];
                zipCMB.DisplayMember = "zip_code";
                zipCMB.ValueMember = "zip_code";
                //zipCMB.DataBindings.Add("SelectedValue", zipDS.Tables[0], "zip_code");
            }
            catch (Exception errmsg)
            {
                MessageBox.Show("Trouble pulling zip codes from database because: " + errmsg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkName(string name)
        {
            bool valid = true;
            try
            {
                if (!Regex.IsMatch(name, "^([a-zA-Z])+$"))
                {
                    valid = false;
                    
                }
            }
            catch (Exception errMsg)
            {
                MessageBox.Show("checkName has an error " + errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valid;
        }
        public bool checkEmail(string email)
        {
            bool valid = true;
            try
            {
                if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    valid = false;
                    
                }
            }
            catch (Exception errMsg)
            {
                MessageBox.Show("checkEmail has an error " + errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valid;
        }
        public bool checkPhoneNum(string PhoneNum)
        {
            bool valid = true;
            try
            {
                if (!Regex.IsMatch(PhoneNum, "[(][0-9]{3}[)][0-9]{3}[-][0-9]{4}"))
                {
                    valid = false;
                   
                }
            }
            catch (Exception errMsg)
            {
                MessageBox.Show("checkPhoneNum has an error " + errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valid;
        }
        //fills combo boxes and opens database upon loading
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                //opens database
                openDatabase();

                //fills combo boxes
                fillCustComboBox();
                fillZipComboBox();
                addressTB.Clear();
                custNameTB.Clear();
                cityTB.Clear();
                stateTB.Clear();
                phoneNumTB.Clear();
                emailAddressTB.Clear();

            }
            catch (Exception errmsg)
            {
                MessageBox.Show("Error in form load event handler: " + errmsg, "Load error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //changes customer information when customer combo box changes indexes
        private void custCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                currentCustomer = custCMB.Text;
                //checks to make sure it loaded properly
                if (currentCustomer != "System.Data.DataRowView" && currentCustomer != "")
                {

                    //gets all the customer information
                    string sql = "SELECT customers.[cust_name], customers.[address], " +
                        "zip_code_tbl.[city], zip_code_tbl.[state], customers.[zip_code], customers.[email_address], customers.[phone_number] " +
                        "from customers, zip_code_tbl " +
                        "where customers.[zip_code] = zip_code_tbl.[zip_code] AND customers.[customer_id] = '" + currentCustomer + "'";
                       
                    //establishes a reader connection
                    OleDbCommand customerInfoCommand;

                    customerInfoCommand = new OleDbCommand(sql, connectionObject);

                    OleDbDataReader customerInfoReader = null;

                    customerInfoReader = customerInfoCommand.ExecuteReader();

                    customerInfoReader.Read();
                    //loads customer information into textboxes
                    custNameTB.Text = customerInfoReader[0].ToString();
                    addressTB.Text = customerInfoReader[1].ToString();
                    cityTB.Text = customerInfoReader[2].ToString();
                    stateTB.Text = customerInfoReader[3].ToString();
                    zipCMB.Text = customerInfoReader[4].ToString();
                    emailAddressTB.Text = customerInfoReader[5].ToString();
                    phoneNumTB.Text = customerInfoReader[6].ToString();

                    updateBtn.Enabled = true;
                    deleteBtn.Enabled = true;
                }

            }
            catch (Exception errmsg)
            {
                MessageBox.Show("Error in combo box index change event handler: " + errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //updates the data as the user changes it
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (updateBtn.Text == "Update")
                {
                    //turns on and off appropriate buttons and textboxes
                    custNameTB.ReadOnly = false;
                    addressTB.ReadOnly = false;
                    phoneNumTB.ReadOnly = false;
                    emailAddressTB.ReadOnly = false;
                    zipCMB.DropDownStyle = ComboBoxStyle.DropDown;
                    zipCMB.Enabled = true;
                    addBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                    custCMB.Enabled = false;
                    updateBtn.Text = "Save these changes";
                }
                else
                {
                    string customerName = custNameTB.Text;
                    string customerAddress = addressTB.Text;
                    string customerZip = zipCMB.Text;
                    string customerEmail = emailAddressTB.Text;
                    string customerPhoneNum = phoneNumTB.Text;
                    bool validName = checkName(customerName);
                    bool validEmail = checkEmail(customerEmail);
                    bool validPhoneNumber = checkPhoneNum(customerPhoneNum);
                    OleDbCommand updateObj;

                    if (!validName)
                    {
                        custNameTB.BackColor = Color.Red;
                        MessageBox.Show("Your name is not a valid input (Must be only letters and no numbers)", "Incorrect name input", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!validEmail)
                    {
                        emailAddressTB.BackColor = Color.Red;
                        MessageBox.Show("Your email is not a valid input (Must be letter and numbers then @ then letters then . and 3 letters)", 
                            "Incorrect email input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(!validPhoneNumber)
                    {
                        phoneNumTB.BackColor = Color.Red;
                        MessageBox.Show("Your phone number is not a valid input (Must be ( 3 numbers ) 3 numbers - then 4 numbers)",
                            "Incorrect email input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //updates the information in the database 
                        string updateSQL = "UPDATE customers SET customers.[cust_name] = '" +
                            customerName + "', customers.[address] = '" + customerAddress +
                            "', customers.[zip_code] = '" + customerZip + "', customers.[email_address] = '" + customerEmail +
                            "', customers.[phone_number] = '" + customerPhoneNum + "' " +
                            "where customers.[customer_id] = '" + currentCustomer + "'";
                        updateObj = new OleDbCommand(updateSQL, connectionObject);
                        updateObj.ExecuteNonQuery();

                        //reenables or disables buttons and textboxes
                        custNameTB.ReadOnly = true;
                        addressTB.ReadOnly = true;
                        emailAddressTB.ReadOnly = true;
                        phoneNumTB.ReadOnly = true;
                        zipCMB.DropDownStyle = ComboBoxStyle.DropDownList;
                        zipCMB.Enabled = false;

                        custNameTB.BackColor = Color.Empty;
                        phoneNumTB.BackColor = Color.Empty;
                        emailAddressTB.BackColor = Color.Empty;

                        addBtn.Enabled = true;
                        deleteBtn.Enabled = true;
                        updateBtn.Text = "Update";

                        custCMB.Enabled = true;
                        MessageBox.Show("The customer infomation was updated successsfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCustComboBox();
                    }
                    
                }

            }
            catch (Exception errMsg)
            {
                MessageBox.Show("There was an error in updating the information: " + errMsg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        //deletes a customer from the database
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sure;

                sure = MessageBox.Show("Are you sure you would like to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (sure == DialogResult.Yes)
                {
                    OleDbCommand deleteCommand;

                    //delete query
                    string deleteSQL = "DELETE from customers where customers.[customer_id] = " +
                        "'" + currentCustomer + "'";
                    deleteCommand = new OleDbCommand(deleteSQL, connectionObject);

                    deleteCommand.ExecuteNonQuery();

                    //clears the boxes after deleting
                    custNameTB.Clear();
                    addressTB.Clear();
                    emailAddressTB.Clear();
                    phoneNumTB.Clear();
                    zipCMB.Text = "";

                    custCMB.Text = "";
                    //refills combo box
                    fillCustComboBox();
                    MessageBox.Show("Customer was successfully deleted.", "Delete confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception errMsg)
            {
                MessageBox.Show("Error in delete button click: " + errMsg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //adds a customer from the text boxes to the database
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (addBtn.Text == "Add")
                {
                    //clears textboxes and enables/disables buttons and boxes as necessary
                    custNameTB.Clear();
                    addressTB.Clear();
                    emailAddressTB.Clear();
                    phoneNumTB.Clear();
                    zipCMB.Enabled = true;
                    zipCMB.DropDownStyle = ComboBoxStyle.DropDown;

                    custNameTB.ReadOnly = false;
                    addressTB.ReadOnly = false;
                    emailAddressTB.ReadOnly = false;
                    phoneNumTB.ReadOnly = false;
                    

                    addBtn.Text = "Add this customer";

                    updateBtn.Enabled = false;
                    deleteBtn.Enabled = false;
                    custCMB.Enabled = false;

                }
                else
                {
                    string customerName = custNameTB.Text;
                    string customerAddress = addressTB.Text;
                    string customerEmail = emailAddressTB.Text;
                    string customerPhoneNum = phoneNumTB.Text;
                    bool validName = checkName(customerName);
                    bool validEmail = checkEmail(customerEmail);
                    bool validPhoneNumber = checkPhoneNum(customerPhoneNum);
                    

                    if (!validName)
                    {
                        custNameTB.BackColor = Color.Red;
                        MessageBox.Show("Your name is not a valid input (Must be only letters and no numbers)", "Incorrect name input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!validEmail)
                    {
                        emailAddressTB.BackColor = Color.Red;
                        MessageBox.Show("Your email is not a valid input (Must be letter and numbers then @ then letters then . and 3 letters)",
                            "Incorrect email input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!validPhoneNumber)
                    {
                        phoneNumTB.BackColor = Color.Red;
                        MessageBox.Show("Your phone number is not a valid input (Must be ( 3 numbers ) 3 numbers - then 4 numbers)",
                            "Incorrect email input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        custNameTB.BackColor = Color.Empty;
                        phoneNumTB.BackColor = Color.Empty;
                        emailAddressTB.BackColor = Color.Empty;
                        string maxCustomerId;
                        string newCustomerId;

                        OleDbCommand addCustomer;

                        string maxIDSQL = "SELECT max(customer_id) FROM customers";

                        //creates reader connection
                        addCustomer = new OleDbCommand(maxIDSQL, connectionObject);

                        OleDbDataReader readerObject = null;

                        readerObject = addCustomer.ExecuteReader();
                        readerObject.Read();

                        maxCustomerId = readerObject[0].ToString();

                        newCustomerId = (Convert.ToDouble(maxCustomerId) + 1).ToString();

                        //adds info to database
                        string addSQL = "INSERT into customers " +
                            "(customer_id, cust_name, address, zip_code, email_address, phone_number) " +
                            "values('" + newCustomerId + "', '" + customerName + "','" + customerAddress + "','" + zipCMB.Text + "','" + customerEmail + "','" + customerPhoneNum + "')";

                        addCustomer = new OleDbCommand(addSQL, connectionObject);
                        addCustomer.ExecuteNonQuery();

                        MessageBox.Show("The new customer was added successfully", "Succesfully added course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //reenables or disables boxes and buttons
                        addBtn.Text = "Add";
                        custNameTB.ReadOnly = true;
                        addressTB.ReadOnly = true;
                        emailAddressTB.ReadOnly = true;
                        phoneNumTB.ReadOnly = true;
                        zipCMB.DropDownStyle = ComboBoxStyle.DropDownList;


                        deleteBtn.Enabled = true;
                        updateBtn.Enabled = true;
                        custCMB.Enabled = true;
                        zipCMB.Enabled = false;
                        fillCustComboBox();
                    }
                }
            }
            catch (Exception errMsg)
            {
                MessageBox.Show("Error in edit btn click: " + errMsg.Message);
            }
        }

        //changes city and state based on the zip code selected
        private void zipCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currentZipCode = zipCMB.Text;
                if (currentZipCode != "System.Data.DataRowView" && currentZipCode != "")
                {

                    //retrieval query
                    string sql2 = "SELECT zip_code_tbl.city, zip_code_tbl.state " + " FROM zip_code_tbl " +
                        " where zip_code_tbl.zip_code = '" + currentZipCode + "'";

                    OleDbCommand zipInfoCommand;

                    zipInfoCommand = new OleDbCommand(sql2, connectionObject);

                    OleDbDataReader zipInfoReader = null;

                    zipInfoReader = zipInfoCommand.ExecuteReader();

                    zipInfoReader.Read();

                    //adds info to text boxes
                    cityTB.Text = zipInfoReader[0].ToString();
                    stateTB.Text = zipInfoReader[1].ToString();


                }

            }
            catch (Exception errmsg)
            {
                MessageBox.Show("Error in combo box index change event handler: " + errmsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
